#include <stdio.h>

// để đọc dữ liệu từ stream vào mảng được trỏ
//syntax: size_t fread(void *ptr, size_t size, size_t nmemb, FILE *stream)



int main ()
{
   FILE *f;
   char str[] = "Hoc C co ban va nang cao tai QTM !!!";

   f = fopen( "baitapc.txt" , "w" );
   fwrite(str , 1 , sizeof(str) , f );

   fclose(f);
  
   return(0);
}
