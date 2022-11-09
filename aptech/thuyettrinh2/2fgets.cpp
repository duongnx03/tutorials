/*Hàm fgets() sẽ đọc từng dòng trong file C, rồi chuyển nội dung từng dòng này vào một chuỗi ký tự,
với số lượng chuyển vào được quyết định trong đối số của hàm.

Hàm fgets() sẽ trả về con trỏ của chuỗi ký tự chứa kết quả đọc file, và trong trường hợp đọc file
thất bại, giá trị [NULL] sẽ được trả về.

syntax: char *fgets(char *str, int n, FILE *stream)
str -- là con trỏ tới một mảng các char nơi chuỗi được đọc va lưu trữ.
n -- là số ký tự lớn nhất có thể đọc từ từng dòng trong file, bao gồm cả ký tự kết thúc chuỗi \0.
*fp --  là con trỏ tới file cần đọc

Hàm fgets() sẽ trả về con trỏ của chuỗi ký tự chứa kết quả đọc file nếu đọc file thành công.
Hàm fgets() sẽ trả về giá trị NULL nếu đọc file thất bại.
*/

#include <stdio.h>

int main() {
  FILE *f;
  char str[100];
  //    mo file de doc
  f = fopen("fgets.txt", "r");
  if (f == NULL) {
    perror("Co loi xay ra khi mo file!");
    return-1;
  }
  else {
    if (fgets(str, 100, f) !=NULL){
      puts(str);
    }
    fclose(f);
  }
  return 0;
}
