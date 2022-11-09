#include <stdio.h>
#include <string.h>

//quet 1 ki tu va in tu ki tu do den cuoia
int main(){
  char str1[50] = "Hello World";
  printf("%s\n", strchr(str1, 'o'));
  printf("%s\n", strstr(str1, "ll"));
}
