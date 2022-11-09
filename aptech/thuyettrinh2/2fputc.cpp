/*Hàm fputc() trong C được sử dụng để ghi một ký tự vào file.
syntax: int fputc(int char, FILE *stream)
char -- ki tu can ghi vao file
stream -- con trỏ của file cần ghi.
*/

#include <stdio.h>

int main() {
  FILE * fPointer;
  char character;
  fPointer = fopen ("Maufputc.txt", "w");//mo file
  fputc('a', fPointer);//ghi 'a' cho file
  fputc('b', fPointer);//ghi 'b' cho file
  fclose(fPointer);

  return 0;
}
