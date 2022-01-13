# Overview
- Software Technology Project
  - Project Name: Music Player Application
  - Discription: Manage tasks in the bookstore
- Members:
- - [Nguyen Hoai Nam](https://github.com/hoainam2310) 
  - [Nguyen Nhat Minh](https://github.com/minh30009) 
- Technology:
  - Language: C#
  - Enviroment: .Net Framework 4.6
- Source: https://github.com/hoainam2310/MusicPlayerApp

# Table of contents
- [Overview](#Overview)
- [Table of contents](#Table-of-contents)
- [1. Determine the problem](#1-Determine-the-problem)
- [2. Design interface](#4-Design-interface)
  - [2.1. Interface list](#41-Interface-list)
  - [2.2. Describe in detail of each interface](#42-Describe-in-detail-of-each-interface)
    - [2.2.1. fDangNhap interface](#421-fdangnhap-interface)
    - [2.2.2. fViewTong interface](#422-fviewtong-interface)
    - [2.2.3. fTaiKhoan interface](#423-ftaikhoan-interface)
    - [2.2.4. fThemSach interface](#424-fthemsach-interface)
    - [2.2.5. fSuaSach interface](#425-fsuasach-interface)
    - [2.2.6. fXoaSach interface](#426-fxoasach-interface)
    - [2.2.7. fThemTacGia interface](#427-fthemtacgia-interface)
    - [2.2.8. fSuaTacGia interface](#428-fsuatacgia-interface)
    - [2.2.9. fXoaTacGia interface](#429-fxoatacgia-interface)
    - [2.2.10. fLinhVuc interface](#4210-flinhvuc-interface)
    - [2.2.11. fLoaiSach interface](#4211-floaisach-interface)
    - [2.2.12. fNhaXuatBan interface](#4212-fnhaxuatban-interface)
    - [2.2.13. fKho interface](#4213-fkho-interface)
    - [2.2.14. fHoaDon interface](#4214-fhoadon-interface)
    - [2.2.15. fThongKe interface](#4215-fthongke-interface)
    - [2.2.16. fBaoCao interface](#4216-fbaocao-interface)
- [5. Design architecture](#5-Design-architecture)
  - [5.1. System architecture](#51-System-architecture)
  - [5.2. Desribe in detail system architecture](#52-Desribe-in-detail-system-architecture)
- [6. Coding conventions](#6-Coding-conventions)
  - [6.1. Naming conventions](#61-Naming-conventions)
  - [6.2. Conventions used when coding](#62-Conventions-used-when-coding)
  - [6.3. Control prefixed](#63-Control-prefixed)
  - [6.4. Source code distribution rules](#64-Source-code-distribution-rules)
- [7. Result](#7-Result)
  - [7.1. Development environment and Deployment environment](#71-Development-environment-and-Deployment-environment)
  - [7.2. Result](#72-Result)
  - [7.3. Development](#73-Development)
# 1. Determine the problem
- Current status survey:
  - Need: Bookstores need a solution to help them manage their titles and sell books to customers.
  - Current status: A retail bookstore that uses personal memmory and notebooks to remember all titles and prices or just use Excel documents for basic management.
  - Technology used: Microsoft Excel or don't use information technology.
  - Limitations of existing software: There is no decicated application for both book sales and management.
- System requirements:
  - Add/Delete/Edit books and book information. 
  - Categorize books based on author, field, type of book and publisher.
  - Apply the payment system for bookstore.
  - Revenue statistics.
  - Manage account.
  - Manage the number of books in stock.

# 2. Design interface
## 2.1. Interface list
| Numbers | Interface Name | Meaning/Notes                                                                          |
|---------|----------------|------------------------------------------------------------------------------------------|
| 1       | fDangNhap      | Log in to the system with username and password                                          |
| 2       | fViewTong      | The main screen shows a list of available titles                                         |
| 3       | fTaiKhoan      | Display the list of system users and edit passwords                                      |
| 4       | fThemSach      | Enter information to add books                                                           |
| 5       | fSuaSach       | Edit the information of the book by the book code                                        |
| 6       | fXoaSach       | Delete the information of the book by the book code                                      |
| 7       | fThemTacGia    | Enter information to add authors                                                         |
| 8       | fSuaTacGia     | Edit the information of the author by the author code                                    |
| 9       | fXoaTacGia     | Delete the information of the author by the author code                                  |
| 10      | fLinhVuc       | Add and remove book field names                                                          |
| 11      | fLoaiSach      | Add and remove book category names                                                       |
| 12      | fNhaXuatBan    | Add and remove publisher names                                                            |
| 13      | fKho           | Show the number of books in stock and add the number of books                            |
| 14      | fHoaDon        | Show bill and bill details. Add/Remove/Edit bills and bill details                       |
| 15      | fThongKe       | Show a list of bills for a selected date range                                           |
| 16      | fBaoCao        | Show a list of sold titles, sales, and profits in the selected date range                |
## 2.2. Describe in detail of each interface
### 2.2.1. fDangNhap interface
![](https://github.com/hoainam2310/BookStore_Management/blob/main/Scene/DangNhap.png)

User fills in Username/Password information to log in. If the login fails more than 3 times, the program will automatically shut down.
### 2.2.2. fViewTong interface
![](https://github.com/hoainam2310/BookStore_Management/blob/main/Scene/Quanlynhasach.png)

Displays the titles in the database, the revenue and the number of customers that day. The Menu above contains the program's functions. 
### 2.2.3. fTaiKhoan interface
![](https://github.com/hoainam2310/BookStore_Management/blob/main/Scene/ThayDoiThongTinAcc.png)

Allows to change the account's password, requires entering the correct old password when you want to change the new password.
### 2.2.4. fThemSach interface
![](https://github.com/hoainam2310/BookStore_Management/blob/main/Scene/ThemSach.png)

Allows adding new titles to the database. Please enter complete information, otherwise, you'll receive a missing input error and ask additional information.
### 2.2.5. fSuaSach interface
![](https://github.com/hoainam2310/BookStore_Management/blob/main/Scene/SuaSach.png)

Allows editting book information in the database. Please enter complete information, otherwise, you'll receive a missing input error and ask for additional information.
### 2.2.6. fXoaSach interface
![](https://github.com/hoainam2310/BookStore_Management/blob/main/Scene/XoaSach.png)

Allows deleting books in the database. Select the book to delete in the list of displayed books.
### 2.2.7. fThemTacGia interface
![](https://github.com/hoainam2310/BookStore_Management/blob/main/Scene/ThemTG.png)

Allows adding new authors to the database. Please enter the author's name, otherwise it will report a missing input error and add for additional information. For the box "Hometown", "Year of birth", "Year of death", if it's not available, you must select the "unknown" button or it will report an error of missing information.
### 2.2.8. fSuaTacGia interface
![](https://github.com/hoainam2310/BookStore_Management/blob/main/Scene/SuaTG.png)

Allows editting author information in the database. Please enter the author's name, otherwise it will report a missing input error and add for additional information. For the box "Hometown", "Year of birth", "Year of death", if it's not available, you must select the "unknown" button or it will report an error of missing information.
### 2.2.9. fXoaTacGia interface
![](https://github.com/hoainam2310/BookStore_Management/blob/main/Scene/XoaTG.png)

Allows deleting authors in the database. Select the authors to delete in the list of displayed authors.
### 2.2.10. fLinhVuc interface
![](https://github.com/hoainam2310/BookStore_Management/blob/main/Scene/LinhVuc.png)

Allows add new fields to the database. If you want to delete, select the fields to delete in the Menu below and press the delete button.
### 2.2.11. fLoaiSach interface
![](https://github.com/hoainam2310/BookStore_Management/blob/main/Scene/LoaiSach.png)

Allows add new book categories to the database. If you want to delete, select the book categories to delete in the Menu below and press the delete button.
### 2.2.12. fNhaXuatBan interface
![](https://github.com/hoainam2310/BookStore_Management/blob/main/Scene/NXB.png)

Allows add new publishers to the database. If you want to delete, select the publishers to delete in the Menu below and press the delete button.
### 2.2.13. fKho interface
![](https://github.com/hoainam2310/BookStore_Management/blob/main/Scene/Kho.png)

Consists of 2 parts:
- Upper part: Allows edit the number of books in stock or delete books.
- Lower part: Add quantity for the books in stock.
### 2.2.14. fHoaDon interface
![](https://github.com/hoainam2310/BookStore_Management/blob/main/Scene/HoaDon.png)
Consists of 2 parts:
- Upper part: Displays a list of existing bills in the database allowing to delete/edit bills and view details of that bill in the next table.
- Lower part: Add/Edit bills, add the items to the bill and ask for full information.
### 2.2.15. fThongKe interface
![](https://github.com/hoainam2310/BookStore_Management/blob/main/Scene/ThongKe.png)
Select the date range for which sales statistics are required, the software will display the bills in the selected date range.
### 2.2.16. fBaoCao interface
![](https://github.com/hoainam2310/BookStore_Management/blob/main/Scene/BaoCao.png)

Export a detailed report on the number of books sold, revenue and profit for the selected date range on the fThongKe interface.
# 5. Design architecture
## 5.1. System architecture
![](https://github.com/hoainam2310/BookStore_Management/blob/main/layer.png)
| Elements   | Explain                               |
|------------|---------------------------------------|
| Client     | Application that interacts with users |
| Data       | Where the system's data is stored     |
## 5.2. Desribe in detail system architecture
![](https://github.com/hoainam2310/BookStore_Management/blob/main/folderview.png)
- The application is designed in a 2-layer model (written in 1 project) including:
  - View handles the interface and handles the task.
  - DAO calls accesses from database (SQL).
# 6. Coding conventions
## 6.1. Naming conventions
| Type        | Discription     | Example      |
|-------------|-----------------|--------------|
| Pascal Case | First letter of the identifier and the first letter of each word that follows must be capitalized. Use Pascal Case to name a name with 3 or more characters | `CodingConv` |
| Camel Case  | First letter of the identifier is lowercase and the first letter of each word that follows must be capitalized          | `codingConv` |
| Uppercase   | All characters in the identifier must be capitalized. Use this rule for identifiers with 2 characters or less | `System.IO ` |
## 6.2. Conventions used when coding
| Element         | Type        | Example               | Note                                    |
|-----------------|-------------|-----------------------|-----------------------------------------|
| Variable name   | Camel Case  | `firstName`           | Noun                                    |
| Constant        | Uppercase   | `FIRST_WEEK_DAY`      | There is an underline between the words |
| Class name, enum| Pascal Case | `CreateUser`          | Noun                                    |
| Parameter       | Camel Case  | `displayTime`         | Noun                                    |
| Property        | Pascal Case | `BackgroundColor`     | Noun                                    |
| Method          | Pascal Case | `GetAge()`            | There is an underline between the words |
| Event           | Pascal Case | `SelectedIndexChanged`| There is an underline between the words |
| Interface       | Pascal Case | `IButtonControl`      | There is an underline between the words |
- Avoid adding meaningless redundant prefixes or suffixes:
  - Không nên:
  ```
  enum BorderEnum { ... }
  class CHuman { ... }
  ```
  - Nên:
  ```
  enum Border { ... }
  class Human { ... }
  ```
- Không thêm tên lớp chứa vào tên thuộc tính:
  - Không nên:
  ```
  Animal.WeightAnimal
  ```
  - Nên:
  ```
  Animal.Weight
  ```
- Tên biến, phương thức bool phải thể hiện được ý nghĩa nếu trả về true hoặc false. Nên sử dụng tiền tố “Is” “Can” “Has” trước tên biến, phương thức:
  - Shouldn't:
  ```
  bool CheckAdmin(int n) { }
  bool Expired() { }
  bool checked = true;
  ```
  - Should:
  ```
  bool IsAdmin(int n) { }
  bool IsExpired() { }
  bool isChecked = true;
  ```
- Don't use the same names (only case sensitive). It's difficult to recognize identifiers especially when in the same context and distinguish identifiers only by uppercase/lowercase letters.
- Don't create 2 namespaces with the same name and differ only in the font style (uppercase/lowercase), for example:
  ```
  Namespace SunAsterisk
  Namespace sunAsterisk
  ```
- It's not recommended to build a method with parameters with the same name and different case only, for example:
  ```
  void MyFunction(string a, string A)
  ```
- Don't buld a type with the same property names and distinguish only in the type, for example:
  ```
  int Color {get, set}
  int COLOR {get, set}
  ```
## 6.3. Control prefixed
- Mandatory naming of all controls involved in background processing. Some controls are set in Pascal style with the following prefix:
| Control      | Prefix  | Example     |
|--------------|---------|-------------|
| Panel        | pnl     | pnlGroup    |
| Checkbox     | chk     | chkReadOnly |
| ComboBox     | cbo     | cboEnglish  |
| Button       | btn     | btnSave     |
| Dialog       | dlg     | dlgFileOpen |
| Form         | frm     | frmLogin    |
| Textbox      | txb     | txbUser     |
| User Control | uc      | ucBooks     |
| Label        | lbl     | lblName     |
| DataGridView | dgv     | dgvBook     |
## 6.4. Source code distribution rules
- Each source file contains only one class. Main class name must match the source file name. For example: Class Student will contained in Student.cs file.
- With enum types, a simple independent struct outside of a class can be declared in a separate source file or another class's source code file.
- Interface must be declared in a separate source file.
- Order of declaration:
  - Declare library
  ```
  using System.Data;
  using System.Drawing;
  ```
  - Declare namespace
  ```
  namespace SQLBackup;
  ```
  - Declare independent structs/enums (if any)
  ```
  public enum HumanClass { A, B, C, D, E }
  ```
  - Declare main class
  ```
  public class Student : Human {}
  ```
# 7. Result
## 7.1. Development environment and Deployment environment
- Application development environment:
  - Operating system: Microsoft Windows 10
  - Database management system: Microsoft SQL Server
  - Design analysis tool: Visual Studio 2019
  - App builder: Visual Studio 2019
- Application deployment environment:
  - Operating system: Microsoft Windows
  - Need to install .Net Framework 4.0 or higher.
  - In order for the program to work, there should be enough dlls in the dll folder.
## 7.2. Result
- The programe has completed most of the functions, but there are still incomplete functions such as: Add account, Export report file in PDF or Excel format.
## 7.3. Development
- Finish incomplete functions and interfaces.
- Impove program performance to match reality.
- Add functions related to the database: backup/restore.
- Add account authorization for software functions.
