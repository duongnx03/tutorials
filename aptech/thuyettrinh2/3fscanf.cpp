/*Hàm fscanf() trong C được sử dụng để đọc từng dòng file theo định dạng chỉ định và ghi lại nội dung đọc được vào một mảng có sẵn.
syntax: int fscanf(FILE *stream, const char *format, ...)
stream -- là con trỏ của file cần đọc.
format-- là định dạng.
Hàm fscanf() trả về chuỗi đầu vào nếu thành công.
Hàm fscanf() trả về giá trị EOF nếu không thành công.
*/
#include <stdio.h>

int main()
{
   char str1[10], str2[10], str3[10];
   int year;
   FILE * fp;

   fp = fopen ("baitapc.txt", "w+");
   fputs("Nhom mot number 1", fp);
   
   rewind(fp);
   fscanf(fp, "%s %s %s %d", str1, str2, str3, &year);
   
   printf("Doc chuoi 1:   |%s|\n", str1 );
   printf("Doc chuoi 2:   |%s|\n", str2 );
   printf("Doc chuoi 3:   |%s|\n", str3 );
   printf("Doc so nguyen: |%d|\n", year );

   fclose(fp);
   
   return(0);
}
