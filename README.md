<!-- ABOUT THE PROJECT -->
## Giới thiệu chung

Phần mềm quản lý phòng khám được xây dựng trên ngôn ngữ C#. Phần mềm tinh gọn, dễ dàng sử dụng, hướng tới tính ổn định cho những nhà quản lý phòng khám tư, với các chức năng thiết yếu phục vụ cho việc quản lý phòng khám dễ dàng hơn

### Công nghệ

* ![MicrosoftSQLServer](https://img.shields.io/badge/Microsoft%20SQL%20Server-CC2927?style=for-the-badge&logo=microsoft%20sql%20server&logoColor=white)
* ![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white)
* ![.Net](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)

<!-- FEATURE -->
## Tính năng

- [x] Đăng nhập, đăng xuất, đổi mật khẩu
- [x] Quản lý người dùng
- [x] Thay đổi quyền hạn người dùng
- [x] Quản lý bệnh án (Tạo, xóa)
- [x] Quản lý thuốc (Thêm, sửa, xóa)
- [x] Quản lý bệnh nhân (Thêm, sửa, xóa)
- [x] Quản lý bệnh nhân (Thêm, sửa, xóa)
- [x] Công cụ tìm kiếm và bộ lọc
- [x] Hệ thống làm việc đa cửa sổ
- [x] Thống kê
- [x] Hỗ trợ kết nối nhiều thiết bị thông qua SQL server

<!-- GETTING STARTED -->
## Yêu cầu

1. [Microsoft SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (Developer Edition hoặc Express Edition)
2. [.NET 6.0](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)
3. Scale Windows tối ưu từ 150% đến 175%

### Hướng dẫn cài đặt

1. Cài đặt [Microsoft SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (Khuyến kích sử dụng bản developer).
2. Chạy [file sql](https://github.com/tqb2512/QuanLyPhongKham/blob/master/SQL%20Scripts/file.sql) để tạo database bằng [SQL Server Management Studio](https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver16) hoặc dùng chạy scirpt bên dưới bằng cmd.
	```
	sqlcmd -S .\ -i "Đường dẫn file sql"
	```
3. Cài đặt phần mềm bằng file setup.
4. Nêu sử dụng MSQL phiên bản dev thì có thể bắt đầu sử dụng ngay. Đối với MSQL Express thì truy cập đường dẫn của phần mềm đã cài, mở file `QuanLyPhongKham.dll.config` và thay đổi trường `connectionString` bằng
	```
	Data Source=.\SQLEXPRESS;Initial Catalog=QUANLYPHONGKHAM;Integrated Security=True
	```

<!-- USAGE EXAMPLES -->
## Hướng dẫn sử dụng

Đối với lần đầu sử dụng hãy đăng nhập bằng tài khoản admin để thiết lập tài khoản người dùng (Khuyến khích thay đổi mật khẩu admin sau khi đăng nhập)
	```
	username: admin1
	password: admin1
	```
## Một số lỗi có thể gặp

* Lỗi button bị mất, layout bị khuất khỏi cửa sổ, và các vấn đề liên quan đến layout của các mục. Lỗi này thường xảy ra đối với các màn hình quá nhỏ hoặc quá lớn để khắc phục tạm thời có thể mở ứng dụng thay đổi `scale` trong `display setting` thấp hơn hoặc lớn hơn, xác nhận và thay đổi `scale` về lại như cũ.

* Lỗi không thể đăng nhập, lỗi này do việc thiết lập `connectionString` chưa đúng. Hãy truy cập thư mục đã cài đặt và thay đổi `connectionString` của file `QuanLyPhongKham.dll.config` cho hợp lệ.

<!-- CONTRIBUTING -->
## Người đóng góp

* [Trịnh Quốc Bảo](https://github.com/tqb2512)
* [Trần Văn Huy](https://github.com/grvhuy)
* [Võ Thiên Phúc](https://github.com/tkj3nfuq)
