/*Hàm fflush() được sử dụng để đẩy hết những ký tự có trong buffer ra stream.
  Sau khi gọi hàm fflush() thì buffer sẽ trống, đảm bảo việc nhập dữ liệu cho các biến sau an toàn. 
syntax: int fflush(FILE *stream)

Hàm fflush() trả về 0 nếu xoá bộ nhớ đệm đầu ra của stream thành công va trả về EOF nếu có lỗi.
*/

#include <stdio.h>

int main() {
  fprintf(stdout, "Hello World! ");
  fflush(stdout);
  fprintf(stderr, "\nVi du ve ham fflush(). ");
  fprintf(stdout, "\nVi du nay su dung ngon ngu C. \n");
  fflush(stdout);
  return 0;
}
