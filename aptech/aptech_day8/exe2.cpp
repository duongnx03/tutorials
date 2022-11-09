#include <stdio.h>
#include <string.h>

int main(){
  char str1[50] = "abc def";
  char str2[50] = "123 456";
  char str3[50] = "abc xyz";

  strcpy(str1, str2);
  printf("%s\n", str1);
  printf("%s\n", str2);

  strcat(str2, str3);
  printf("%s\n", str2);
  printf("%s\n", str3);

  printf("%d\n",strcmp(str1, str3)); 
  char check = 'a';
  printf("%d\n", check);

  printf("%zu\n", strlen(str2));

}
