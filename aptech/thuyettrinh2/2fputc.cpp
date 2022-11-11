/*Hàm fputc() trong C được sử dụng để ghi một ký tự vào file.
syntax: int fputc(int char, FILE *stream)
char -- ki tu can ghi vao file
stream -- con trỏ của file cần ghi.
Hàm fputc() trả về ký tự được ghi vào file nếu thành công va trả về giá trị EOF nếu thất bại.
*/

#include <stdio.h>

int main() {
  FILE * fPointer;

  fPointer = fopen ("Hamfputc.txt", "w");//mo file
  fputc('a', fPointer);//ghi 'a' cho file
  fputc('b', fPointer);//ghi 'b' cho file
  fclose(fPointer);

  return 0;
}
