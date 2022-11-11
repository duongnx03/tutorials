/*Hàm fgetc() trong C được sử dụng để đọc từng ký tự một từ một file đã cho. 
syntax: int fgetc(FILE *stream)
stream -- con trỏ của file cần đọc.
 Hàm fgetc() trả về mã ASCII của ký tự được đọc ra từ file va nếu vị trí đọc ký tự là cuối file hoặc đọc 
 file thất bại, hàm trả về giá trị EOF.
*/ 

# include <stdio.h>
int main(){

  FILE *fp ;
  char c ;
  printf( "Mo file test.c" ) ;
  fp = fopen ( "test.c", "r" ) ; // Mo file co san de doc
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
