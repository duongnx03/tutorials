/*Hàm fprintf() trong C được sử dụng để ghi dữ liệu vào file theo định dạng chỉ định. Ta có thể định dạng các dữ liệu thuộc nhiều kiểu khác nhau, sau đó ghi chúng vào các file có định dạng cố định.
 syntax: int fprintf(FILE *stream, const char *format, ...)
 strem -- con trỏ tới đối tượng FILE
 format -- định dạng ghi vào file của dữ liệu.
 Hàm fprintf() trả về một số thuộc kiểu int, là số ký tự có trong chuỗi đã tạo nếu ghi file thành công va trả về giá trị EOF nếu ghi file thất bại.
  */

#include <stdio.h>  
int main(){  
   FILE *f;  
   f = fopen("file.txt", "w");//mo file 
   fprintf(f, "Programing\n"); //nhap du lieu
   fclose(f);//dong file 
}  
