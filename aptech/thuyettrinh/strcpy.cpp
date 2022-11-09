#include <stdio.h>
#include <string.h>

int main(){
  char str1[] = "Nguyen Hue";
  char str2[] = "Quang Trung";

  printf("ten truoc khi len ngoi la: %s\n", str1);
  strcpy(str2, str1);

  printf("ten khi len ngoi la: %s\n", str2);
}
