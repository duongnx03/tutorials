/*- Hàm fopen() trong C được sử dụng để mở file.
syntax: FILE* fopen (const char* filename, const char* mode);
 Filename: con trỏ tới file cần mở.
 Mode: chế độ mở file.
 Hàm fopen() trả về con trỏ đến đối tượng FILE nếu mở file thành công va trả về giá trị NULL nếu mở file thất bại.

- Hàm fclose() trong C được sử dụng để đóng file đã mở từ trước đó. 
syntax: int fclose(FILE *stream)
 Stream: con trỏ của file cần đóng.
 Hàm fclose() khi kết thúc file bình thường sẽ trả về 0 va trường hợp kết thúc file bất thường, trả lại giá trị kiểu EOF

*/
#include <stdio.h>
#include <string.h>

int main(){
  FILE *f;
  f = fopen("Test.txt", "w");
  
  if (f == NULL) {
    printf("error\n");
  }

  
  int fclose(FILE *f);
}

