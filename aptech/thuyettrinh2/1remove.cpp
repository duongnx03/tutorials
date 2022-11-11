/* Ham remove() xóa filename đã cho để nó không thể truy cập được nữa.
 syntax: int remove(const char *filename)
 filename −- là chuỗi chứa tên file để được xóa.
 
 Nếu thành công thì trả về 0. Nếu có lỗi, trả về -1 và errno được thiết lập thích hợp
*/
#include <stdio.h>
#include <string.h>

int main ()
{
  int abc;
  FILE *f; // khai bao 1 con tro kieu FILE- can thiet de co su ket noi giua program and file
  char filename[] = "baitapc.txt";

  f = fopen(filename, "w");//tao 1file chi co the ghi 

  fprintf(f, "%s", "Hello World!!!");
  fclose(f);

  abc = remove(filename);
  //filename - chuoi chua ten file can xoa

  if(abc == 0) 
  {
    printf("Xoa file thanh cong !!!");
  }
  else 
  {
    printf("Error: khong the xoa file");
  }

  return(0);
}
