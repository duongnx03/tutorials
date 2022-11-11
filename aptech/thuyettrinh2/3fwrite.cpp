/*Hàm fwrite() để ghi dữ liệu từ mảng được trỏ bởi ptr tới Stream đã cho
syntax: size_t fwrite(const void *ptr, size_t size, size_t nmemb, FILE *stream)
ptr -- Đây là con trỏ tới mảng các phần tử được ghi.
size -- chỉ định số byte của mỗi mục sẽ được ghi.
nmemb -- số mục sẽ được viết.
stream-- là một con trỏ đến tệp nơi các mục dữ liệu sẽ được ghi.
Hàm fwrite() trả về số lượng các mục được ghi thành công vào tệp va trả về một số nhỏ hơn n nếu không thành công.

*/
#include <stdio.h>
int main ()
{
  FILE *f;
  char str[] = "Hello World!!!";

  f = fopen( "baitapc.txt" , "w" );
  fwrite(str , 1 , sizeof(str) , f );

  fclose(f);

  return(0);
}
