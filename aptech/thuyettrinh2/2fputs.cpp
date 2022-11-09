/* Hàm fputs() - ghi một chuỗi ký tự vào file
   syntax: int fputs(const char  * s,  FILE  * stream)

   str -- Đây là một mảng chứa dãy ký tự kết thúc với null được ghi.
   stream -- con trỏ của file cần ghi.
   Hàm fputs() trả về 0 nếu ghi chuỗi vào file thành công va trả về giá trị EOF nếu ghi chuỗi vào file thất bại.
*/

#include <stdio.h>
 
int main() {
   FILE *fp;
   // open file
   fp = fopen("file2.txt", "w");
   // write string into file
   fputs("hello c programming!", fp);
   // close file
   fclose(fp);
}
