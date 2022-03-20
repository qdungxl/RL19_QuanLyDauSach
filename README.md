# RL19_QuanLyDauSach
## 1. Giới thiệu
Bài tập rèn luyện 19 - Phần mềm quản lý nhà sách Khai Trí. Phần mềm có chức năng hiển thị danh sách sách của Nhà Sách theo Loại sách và theo Nhà xuất bản. Khi tra một đầu sách sẽ có được thông tin chi tiết tên sách, giá sách, loại sách và nhà xuất bản.

Tác giả: Mai Quốc Dũng

Liên hệ: maiquocdung95@gmail.com
## 2. Mô tả phần mềm
Phần mềm viết theo viết theo kiến trúc đa tầng, dữ liệu sách của nhà sách sẽ được lưu trữ bằng MS SQL.
### 2.1. Sơ đồ dữ liệu
![image](https://user-images.githubusercontent.com/94212972/159163162-85f5fcc7-ba6e-4a0a-b3fb-bf5c50fab30d.png)
### 2.2. Giao diện
![image](https://user-images.githubusercontent.com/94212972/159163326-17f24fca-f9c4-4656-97b0-631d8d8a8b97.png)
### 2.3. Sử dụng phần mềm
Chọn xem theo Loại sách hoặc xem theo Nhà xuất bản, dữ liệu sẽ được tải từ sql lên và hiển thị lên treeview.

Khi nhấp chuột vào node trên treeview, dữ liệu của node(loại sách hoặc nhà xuất bản) sẽ được tải từ sql lên listview.

Khi nhấp vào một item trong listview thông tin chi tiết của item đó sẽ được hiện lên các textbox tương ứng.
