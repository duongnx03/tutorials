#include <stdio.h>
#include <string.h>

int main(){
  char str1[] = "Ha Noi";
  char str2[] = "Ho Chi Minh";
  char str3[] = "Da Nang";

  int a, b, c;

  a = strcmp(str1 , str2);
  printf("%s so sanh voi %s thi ket qua la: %d\n", str1, str2, a);
  b = strcmp(str1 , str3);
  printf("%s so sanh voi %s thi ket qua la: %d\n", str1, str3, b);
  c = strcmp(str2 , str3);
  printf("%s so sanh voi %s thi ket qua la: %d\n", str2, str3, c);

}
