﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.Face;
using Emgu.CV.CvEnum;
using System.IO;
using BUS;
using DTO;
using System.Threading;
using System.Diagnostics;

namespace GUI
{
    public partial class DiemDanh : Form
    {
        private Capture quayVideo = null;
        static readonly CascadeClassifier cascadeClassifier = new CascadeClassifier("haarcascade_frontalface_alt.xml");
        Mat frame = new Mat();
        private bool facedetection = false;//nhan diện khuôn mặt
        private Image<Bgr, Byte> currentFrame = null;// khuôn mặt hiện tại
        private bool isTrained = false;// Kiểm tra khuôn mặt

        EigenFaceRecognizer recognizer;
        List<Image<Gray, Byte>> TrainedFaces = new List<Image<Gray, byte>>();
        List<int> PersonsLabes = new List<int>();
        List<string> PersonsMSSV = new List<string>();
        List<string> PersonsLop = new List<string>();

        string Mssv = null, Lop = null, svHienDien = null, svVang = null;
        public DiemDanh()
        {
            InitializeComponent();
            btnStop.Enabled = false;
            btnDiemDanh.Enabled = false;
            btnThongKe.Enabled = false;
            btnLuu.Enabled = false;
            ChonLop();
        }
       
        private void DiemDanh_Load(object sender, EventArgs e)
        {
            timer.Start();
            lblNgay.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
        protected void ChonLop()
        {
            SinhVienDTO sv = new SinhVienDTO();
            LopHocDTO lh = new LopHocDTO();
            cboChonLop.DataSource = SinhVienBUS.LayDSLopHoc(sv);
            cboChonLop.DisplayMember = "Ma_Lop";
            cboChonLop.ValueMember = "Ma_Lop";

            

        }
        private void ProcessFrame(object sender, EventArgs e)
        {
            quayVideo.Retrieve(frame, 0);
            currentFrame = frame.ToImage<Bgr, Byte>().Resize(320, 240, Inter.Cubic);


            //nhận diện khuôn mặt: facedetection
            if (facedetection)
            {
                Mat grayImage = new Mat();//image của thư viên emgucv
                CvInvoke.CvtColor(currentFrame, grayImage, ColorConversion.Bgr2Gray);//Chuyển hình thành màu xám
                CvInvoke.EqualizeHist(grayImage, grayImage);// cân bằng độ sáng

                Rectangle[] faces = cascadeClassifier.DetectMultiScale(grayImage, 1.2, 10, new Size(20, 20));// xác định khuôn mặt
                if (faces.Length > 0)
                {
                    foreach (var face in faces)
                    {
                        // vẽ hình vuông vào mặt
                        CvInvoke.Rectangle(currentFrame, face, new Bgr(Color.Red).MCvScalar, 2);

                        //add khuôn mặt : resualtFace
                        Image<Bgr, Byte> resualtFace = currentFrame.Convert<Bgr, Byte>();
                        resualtFace.ROI = face;// xác dịnh khu vực khuôn mặt
                        imgBox2.SizeMode = PictureBoxSizeMode.StretchImage;// Chỉnh size cho imagebox;
                        imgBox2.Image = resualtFace.Bitmap;

                        //Kết quả khuông mặt: grayFaceResult
                        if (isTrained)
                        {
                            Image<Gray, Byte> grayFaceResult = resualtFace.Convert<Gray, Byte>().Resize(100, 100, Inter.Cubic);
                            CvInvoke.EqualizeHist(grayFaceResult, grayFaceResult);// can bằng
                            var result = recognizer.Predict(grayFaceResult);// nhận dạng khuôn mặt mới truyền vào
                            //imgBox.Image = grayFaceResult.Bitmap;
                            //imgBox2.Image = TrainedFaces[result.Label].Bitmap;
                            imgBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                            //Here results found known faces
                            if (result.Label != 0 && result.Distance < 2000)
                            {
                                CvInvoke.PutText(currentFrame, PersonsMSSV[result.Label], new Point(face.X - 2, face.Y - 2),
                                            FontFace.HersheyComplex, 0.7, new Bgr(Color.Orange).MCvScalar);// vẽ khung chữ xung quanh khuôn mặt
                                CvInvoke.Rectangle(currentFrame, face, new Bgr(Color.Green).MCvScalar, 2);// hiển thị khung xanh
                                Mssv = PersonsMSSV[result.Label];
                                Lop = PersonsLop[result.Label];
                                try
                                {
                                    this.Invoke(new MethodInvoker(delegate ()
                                    {
                                        //in sinh viên đi học
                                        if (Lop == cboChonLop.Text)
                                        {
                                            if (lstDiHoc.Items.Count == 0)
                                            {
                                                // nếu lst đi học chưa có ai thì add vào sinh viên 
                                                lstDiHoc.Items.Add(Mssv + " " + Lop);
                                            }
                                            else
                                            {
                                                if (lstDiHoc.FindString(Mssv) != -1) {
                                                    //kiểm tra sinh viên đó có tồn tại ở list chưa nếu có thì không add
                                                }
                                                else
                                                {
                                                    lstDiHoc.Items.Add(Mssv + " " + Lop);
                                                }
                                            }

                                            lblLop.Text = Lop;
                                            lblMSSV.Text = Mssv;
                                        }
                                    }));
                                }
                                catch (Exception ex)
                                {
                                  
                                }
                                
                                
                               
                            }

                            //here results did not found any know faces
                            else
                            {
                                CvInvoke.PutText(currentFrame, "Unknown", new Point(face.X - 2, face.Y - 2),
                                    FontFace.HersheyComplex, 0.7, new Bgr(Color.Orange).MCvScalar);
                                CvInvoke.Rectangle(currentFrame, face, new Bgr(Color.Red).MCvScalar, 2);

                            }


                        }

                    }

                }
            }

            imgBox.Image = currentFrame.Bitmap;
        }


        private bool TrainImagesFromDir()// lấy hình ảnh trong file
        {
            double Threshold = 2000;
            int ImagesCount = 0;
            TrainedFaces.Clear();
            PersonsLabes.Clear();
            try
            {
                string path = Directory.GetCurrentDirectory() + @"\TrainedImages";
                string[] files = Directory.GetFiles(path, "*.bmp", SearchOption.AllDirectories);
                foreach (var file in files)
                {
                    Image<Gray, Byte> trainedImage = new Image<Gray, Byte>(file).Resize(100, 100, Inter.Cubic);
                    CvInvoke.EqualizeHist(trainedImage, trainedImage);// cân bằng độ sáng.
                    TrainedFaces.Add(trainedImage);// add khuôn mặt có vào list traind
                    PersonsLabes.Add(ImagesCount);// gắn số tứ tự cho hình ảnh
                    string mssv = file.Split('\\').Last().Split('_')[0];//lay mssv trước dấu _
                    string lop = file.Split('\\').Last().Split('_')[1];
                    PersonsMSSV.Add(mssv);
                    PersonsLop.Add(lop);
                    ImagesCount++;
                }
                if (TrainedFaces.Count() > 0)
                {

                    recognizer = new EigenFaceRecognizer(ImagesCount, Threshold);//khởi tạo để sử dụng phương thức train
                    recognizer.Train(TrainedFaces.ToArray(), PersonsLabes.ToArray());// ngắn số thứ tự của hình ảnh, vào ảnh

                    isTrained = true;
                    //Debug.WriteLine(ImagesCount);
                    //Debug.WriteLine(isTrained);
                    return true;
                }
                else
                {
                    isTrained = false;
                    return false;
                }
            }
            catch (Exception ex)
            {
                isTrained = false;
                MessageBox.Show("Chưa có dữ liệu nhận dạng sinh viên !");
                return false;
            }
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            lblGio.Text = DateTime.Now.ToString("HH:mm:ss");
            timer.Start();
        }

        private void btnDiemDanh_Click(object sender, EventArgs e)
        {
            btnThongKe.Enabled = true;
            facedetection = true; // quet khuon mat 
            TrainImagesFromDir();//train hinh anh tuong duong khuon mat
            btnStart.Enabled = false;
            cboChonLop.Enabled = false;
            //cam = new VideoCaptureDevice(camera[0].MonikerString);
        }

        bool ktThongKe = false;

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            facedetection = false;
            btnStart.Enabled = false;
            btnDiemDanh.Enabled = false;
            imgBox2.Dispose();
            btnLuu.Enabled = true;
            cboChonLop.Enabled = true;
            lblLop.Text = "";
            lblMSSV.Text = "";
       
            //hien thi sinh vien len list vang
            //PersonsLabes so hinh anh
            // nếu list đi học không có ai thì add tất cả Masv có hình ảnh vào list vắng
                if (lstDiHoc.Items.Count == 0)
                {
                    for (int i = 0; i < PersonsLabes.Count; i++)
                    {

                        if (lstVang.FindString(PersonsMSSV[i]) != -1)
                        {
                            // kiểm tra list vắng có tồn tại mssv đó chưa
                        }
                        else
                        {
                            if (PersonsLop[i] == cboChonLop.Text)
                            {
                                lstVang.Items.Add(PersonsMSSV[i] + " " + PersonsLop[i]);
                            }
                        }
                        
                    }
                }
                else
                {
                    for (int i = 0; i < PersonsLabes.Count; i++)
                    {
                         if (lstDiHoc.FindString(PersonsMSSV[i]) != -1)
                            {
                                //nếu trong list đi học tồn tại mssv rồi thì không add qua list vắng
                            }
                            else
                            {
                                if (lstVang.FindString(PersonsMSSV[i]) != -1)
                                {
                                    //kiểm tra list vắng có tồn tại mssv đó chưa, có không add
                                }
                                else
                                {
                                    if (PersonsLop[i] == cboChonLop.Text)
                                    {
                                        lstVang.Items.Add(PersonsMSSV[i] + " " + PersonsLop[i]);
                                    }
                                }

                            }
                        
                    }
                }
            
            
            lblHienDien.Text = lstDiHoc.Items.Count.ToString();
            lblVang.Text = lstVang.Items.Count.ToString();
        }

        private void btnDiemDanhTC_Click(object sender, EventArgs e)
        {
            SinhVienDTO sv = new SinhVienDTO();
            sv.Ma_SV = txtDiemDanhTC.Text;
            sv.SoNgayHoc = 1;
            sv.SoNgayVang = 0;
            if (SinhVienBUS.CapNhatChuyenCan(sv))
            {
                MessageBox.Show("Điểm danh thành công");
                txtDiemDanhTC.Text = "";
            }
            else
            {
                MessageBox.Show("Sinh viên không tồn tại");
                txtDiemDanhTC.Text = "";
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (quayVideo == null)
            {
                quayVideo = new Capture();
                quayVideo.ImageGrabbed += ProcessFrame;
                quayVideo.FlipHorizontal = !quayVideo.FlipHorizontal;
                quayVideo.Start();
            }
            btnStop.Enabled = true;
            btnDiemDanh.Enabled = true;
            cboChonLop.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
            btnDiemDanh.Enabled = false;
            btnThongKe.Enabled = false;
            cboChonLop.Enabled = true;
            btnLuu.Enabled = false;

            if (quayVideo != null)
            {
                facedetection = false;
                quayVideo.Dispose();
                imgBox.Image = null;
                imgBox2.Image = null;
            }
            quayVideo = null;
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void txtDiemDanhTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // ko cho phep nhap dau .
            else if ((e.KeyChar == '.') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf('.') == -1))
            {
                e.Handled = true;
            }
            else if (e.Handled = (e.KeyChar == (char)Keys.Space))
            {

            }

            else
            {
                e.Handled = false;
            }
        }

        private void cboTim_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void DiemDanh_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (quayVideo != null)
            {
                quayVideo.Dispose();
                facedetection = false;
            }
            quayVideo = null;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            SinhVienDTO sv = new SinhVienDTO();
            cboChonLop.Enabled = true;
            btnStart.Enabled = false;
            DialogResult dialogResult = MessageBox.Show("Bạn Có Muốn Lưu Dữ Liệu ?", "Lưu Đữ Liệu ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                //trường hợp cả lớp vắng
                if (lstDiHoc.Items.Count == 0)
                {
                    for (int i = 0; i < lstVang.Items.Count; i++)
                    {
                        sv.SoNgayVang = 1;
                        sv.Ma_SV = lstVang.Items[i].ToString().Split(' ')[0];
                        sv.SoNgayHoc = 0;
                        SinhVienBUS.CapNhatChuyenCan(sv);
                    }

                }
                //trường hợp cả lớp đi học
                else if (lstVang.Items.Count == 0)
                {
                    for (int i = 0; i < lstDiHoc.Items.Count; i++)
                    {
                        sv.SoNgayVang = 0;
                        sv.Ma_SV = lstDiHoc.Items[i].ToString().Split(' ')[0];
                        sv.SoNgayHoc = 1;
                        SinhVienBUS.CapNhatChuyenCan(sv);
                    }

                }
                //trường hợp có đi học có vắng
                else
                {
                    for (int i = 0; i < lstVang.Items.Count; i++)
                    {
                        sv.SoNgayVang = 1;
                        sv.Ma_SV = lstVang.Items[i].ToString().Split(' ')[0];
                        sv.SoNgayHoc = 0;
                        SinhVienBUS.CapNhatChuyenCan(sv);
                    }

                    for (int i = 0; i < lstDiHoc.Items.Count; i++)
                    {
                        sv.SoNgayVang = 0;
                        sv.Ma_SV = lstDiHoc.Items[i].ToString().Split(' ')[0];
                        sv.SoNgayHoc = 1;
                        SinhVienBUS.CapNhatChuyenCan(sv);
                    }

                }
                MessageBox.Show("Lưu Thông Tin Thành Công");
                lstDiHoc.Items.Clear();
                lstVang.Items.Clear();
                lblHienDien.Text = "00";
                lblVang.Text = "00";
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Lưu Thông Tin Thất Bại");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            lstDiHoc.Items.Clear();
            btnDiemDanh.Enabled = false;
            btnThongKe.Enabled = false;
            btnLuu.Enabled = false;
            lstVang.Items.Clear();
            cboChonLop.Enabled = true;
            lblLop.Text = "";
            lblMSSV.Text = "";
            lblHienDien.Text = "00";
            lblVang.Text = "00";
            txtDiemDanhTC.Text = "";
            if(quayVideo!=null)
            {
                facedetection = false;
                quayVideo.Dispose();
                btnStart.Enabled = true;
                imgBox.Image = null;
                imgBox2.Image = null;

            }
            quayVideo = null;
           
        }

        


    }
}
