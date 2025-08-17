# 📚 Esemka School Library

Aplikasi **Library Management System** berbasis **C# WinForms + LINQ to SQL + SQL Server** yang mendukung pengelolaan buku, kategori, anggota, dan peminjaman buku.

---

## ✨ Fitur Utama
- 🔍 **Manajemen Buku**
  - Tambah, edit, hapus, dan lihat daftar buku
  - Informasi lengkap: Judul, Penulis, Tahun Terbit, Rating, Likes, Gambar, Stok
- 🗂 **Manajemen Kategori**
  - Tambah kategori baru dengan gambar/icon
  - Hubungkan buku dengan kategori
- 👥 **Manajemen Member**
  - Mendukung **Member** sebagai user dan **Non-Member** sebagai admin
  - Sistem login sederhana dengan username + password
- 📖 **Peminjaman Buku**
  - Catat data peminjaman & pengembalian
  - Mendukung kategori pinjam (misalnya: harian, mingguan, bulanan)
- 💾 **Koleksi Buku Tersimpan**
  - Member & Non-Member dapat menyimpan daftar buku favorit
- 🎨 **User Interface**
  - CRUD berbasis Windows Forms dengan antarmuka interaktif
- 🔄 **LINQ to SQL**
  - Query database lebih sederhana, aman, dan efisien

---

## 🛠️ Teknologi yang Digunakan
- **C# (.NET Framework / WinForms)**
- **Guna.UI2.WinForms**
- **SQL Server** (Database)
- **LINQ to SQL** (ORM)
- **Visual Studio 2012 or higger**

---

## 🗃️ Struktur Database

### Entity Relationship Diagram (ERD)
![Database Diagram](https://res.cloudinary.com/dueixuonp/image/upload/v1755425490/DbDiagram_sxusvr.png)

### 📑 Books
- `Id` (PK, int, identity)
- `Title` (nvarchar 255)
- `Categories_Id` (FK → Categories.Id)
- `Writer` (varchar 100)
- `Publication_Year` (int)
- `Synopsis` (varchar max)
- `Rating` (int)
- `Likes` (int)
- `Image` (image, nullable)
- `Stock` (int, nullable)

### 🗂 Categories
- `Id` (PK, int, identity)
- `Name` (varchar 100)
- `Image` (image)

### 👤 Member
- `Id` (PK, int, identity)
- `Name` (varchar 100)
- `Password` (varchar 50)

### 👥 Non-Member
- `Id` (PK, int, identity)
- `Name` (varchar 100)
- `Password` (varchar 50)

### 📦 Borrow_Books
- `Id` (PK, int, identity)
- `member_Id` (FK → Member.Id)
- `book_Id` (FK → Books.Id)
- `borrow_category_Id` (FK → Borrow_Category.Id)
- `borrow_date` (datetime)
- `book_return_date` (datetime)
- `is_return` (varchar 5)

### 🏷 Borrow_Category
- `Id` (PK, int, identity)
- `Category` (varchar 50)

### 💾 Saved_Books
- `Id` (PK, int, identity)
- `Book_Id` (FK → Books.Id)
- `Member_Id` (nullable, FK → Member.Id)
- `Non_Member_Id` (nullable, FK → Non-Member.Id)

---

## 📷 Tampilan Aplikasi
### Login Form
![Login Form](https://res.cloudinary.com/dueixuonp/image/upload/v1755425502/HomeForm_yeaghv.png)

### Main Form
![Main Form](https://res.cloudinary.com/dueixuonp/image/upload/v1755425496/MainForm_udb4zn.png)

### Search Form
![Search Form](https://res.cloudinary.com/dueixuonp/image/upload/v1755425497/SearchForm_y9s1xu.png)

### Detail Form
![Detail Form](https://res.cloudinary.com/dueixuonp/image/upload/v1755425494/DetailForm_ynwyox.png)

### Borrowed Form
![Borrowed Form](https://res.cloudinary.com/dueixuonp/image/upload/v1755425493/MyBorrowBook_yhsya6.png)

### Manage Borrowed Form
![Manage Borrowed Form](https://res.cloudinary.com/dueixuonp/image/upload/v1755425494/ManageBorrowBook_mza70o.png)

### CRUD User Form
![CRUD User Form](https://res.cloudinary.com/dueixuonp/image/upload/v1755425491/CrudUser_kalmxy.png)

### CRUD Category Form
![CRUD Category Form](https://res.cloudinary.com/dueixuonp/image/upload/v1755428968/CrudCategory_gzjpvz.png)

### CRUD Book Form
![CRUD Book Form](https://res.cloudinary.com/dueixuonp/image/upload/v1755425494/CrudBookForm_p5gphr.png)

---

## 🚀 Cara Menjalankan



1. Clone repo ini:
   ```bash
   git clone https://github.com/abayDahln/Esemka_School_Library.git
   ```
   ```bash
   cd Esemka_School_Library
   ```

2. Import database ke server kamu.

3. Tambahkan data ke database agar terlihat di aplikasi.

3. Buka Esemka School Library.sln dengan Visual Studio.

4. Cari file App.config di Solution Explorer atau shortcut (Ctrl + ;) 

5. Sesuaikan server database kamu di file App.config:

![AppConfig](https://res.cloudinary.com/dueixuonp/image/upload/v1755425494/AppConfig_dnnqk0.png)

6. Jalankan aplikasinya dengan tombol Run di atas atau shortcut (F5)

---

## 📌 Catatan
Aplikasi ini dibuat untuk keperluan **tugas sekolah** dan bukan untuk penggunaan secara umum dikarenakan:  
- Masih terdapat beberapa bug ketika dijalankan.  
- Struktur dan kerapihan kode belum sepenuhnya optimal.  
- Ukuran project dan database terlalu besar untuk aplikasi desktop sederhana.

---

## 🎉 Fun Fact
- Ini adalah project pertama saya yang dibuat dengan niat. 
- Aplikasi ini terinspirasi dari aplikasi **perpustakaan sekolah** dan aplikasi desktop sederhana.  
- Dibuat sendiri selama 1 bulan + 1 minggu.  

---

## 📜 Lisensi
Project ini dirilis sebagai **open source** di bawah lisensi [MIT License](LICENSE).  
Artinya, kamu bebas menggunakan, menyalin, memodifikasi, dan mendistribusikan project ini,  
selama menyertakan lisensi yang sama.  

--- 
  
<p align="center">  
  Made with ❤️ by <b>Abay Dahlan Havizh</b>  
</p>

<p align="right">  
  January, 2025
</p>