//để ghi dữ liệu từ mảng được trỏ bởi ptr tới Stream đã cho
//syntax: size_t fwrite(const void *ptr, size_t size, size_t nmemb, FILE *stream)

#include <stdio.h>
int main ()
{
  FILE *f;
  char str[] = "Hoc C co ban va nang cao tai QTM !!!";

  f = fopen( "baitapc.txt" , "w" );
  fwrite(str , 1 , sizeof(str) , f );

  fclose(f);

  return(0);
}
