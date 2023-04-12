using System;

namespace Dosen
{
    class Dosen
    {
        private int Id { get; set; }
        private string Nama { get; set; }
        private int Nik { get; set; }
        private string Gender { get; set; }
        private string Course { get; set; }

        public Dosen()
        {
            Id = 1;
            Nama = "Dosen Pengampu";
            Nik = 123456789;
            Gender = "Male";
            Course = "Pemrograman Berorientasi Objek";
        }

        public void display()
        {
            Console.WriteLine("Nama: " + Nama);
            Console.WriteLine("NIK: " + Nik);
            Console.WriteLine("Gender: " + Gender);
            Console.WriteLine("Course: " + Course);
        }

        public void attDosen(string nama, int nik) 
        {
            Nama = nama;
            Nik = nik;
        }

        public void addCourse(string newCourse)
        {
            Course += ", " + newCourse;
        }
    }
}