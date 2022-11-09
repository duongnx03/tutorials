/*Hàm fgetc() trong C được sử dụng để đọc từng ký tự một từ một file đã cho. 
  Nó trả về EOF khi kết thúc file.
syntax: int fgetc(FILE *stream)
*/ 

# include <stdio.h>
int main(){

  FILE *fp ;
  char c ;
  printf( "Mo file test.c" ) ;
  fp = fopen ( "test.c", "r" ) ; // Mo file co san
  if ( fp == NULL )
  {
    printf ( "\nKhong the mo file test.c" ) ;
    return 1;
  }
  printf( "\nDoc file test.c" ) ;
  //Dung vong lap de doc tu ky tu dau tien den ky tu cuoi trong file
  while ( 1 )
  {
    c = fgetc ( fp ) ; // Doc file
    if ( c == EOF )
      break ;
    printf ( "%c", c ) ;
  }
  printf("\nDong file test.c") ;
  fclose ( fp ) ; // Dong file
  return 0;
}
