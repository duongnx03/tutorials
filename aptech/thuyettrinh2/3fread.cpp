
/*Hàm fread() trong C được sử dụng để đọc dữ liệu từ stream vào mảng được trỏ
syntax: size_t fread(void *ptr, size_t size, size_t nmemb, FILE *stream)
ptr -- là con trỏ chỉ tới vùng nhớ nhận dữ liệu từ tập tin.
size -- kích thước của mỗi phần tử.
nmemb -- số phần tử được đọc từ tập tin.
FILE *stream -- con trỏ tập tin đã được mở.
Hàm fread() trả về số phần tử đã đọc được từ tập tin nếu thành công va nếu số này khác với tham số nmemb
, thì một lỗi đã xảy ra hoặc bắt gặp End-Of-File.

*/
#include <stdio.h>
#include <string.h>
int main()
{
   FILE *fp;
   char c[] = "Hello World!!!";
   char buffer[100];  
   fp = fopen("baitapc.txt", "w+");  // mo file de doc va ghi 
   fwrite(c, strlen(c) + 1, 1, fp);  // Ghi du lieu vao file 
   fseek(fp, SEEK_SET, 0);    // thiet lap vi tri con tro tim kiem ve dau file 
   fread(buffer, strlen(c)+1, 1, fp); // Doc va hien thi du lieu 
   printf("%s\n", buffer);
   fclose(fp);
   
   return(0);
}
