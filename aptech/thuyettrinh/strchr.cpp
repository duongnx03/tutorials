#include <stdio.h>
#include <string.h>

int main(){
  char str1[] = "Ho Chi Minh";
  char chr = 'o';

  if (strchr(str1, chr) != NULL) {
    printf("%c co xuat hien trong chuoi %s\n", chr, str1);
  }else {
    printf("%c khong xuat hien trong chuoi %s\n", chr, str1);
  }
}
