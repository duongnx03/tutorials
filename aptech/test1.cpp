#include <stdio.h>

int main(){
  FILE *f;

  char str[] = "Hello World!!!";
  char str1[50];

  f = fopen("baitap.txt", "w+");
  fwrite(str, sizeof(str), 1, f);

  fseek(f, SEEK_SET, 0);
  fread(str1, sizeof(str1), 1, f);

  fclose(f);
  return 0;

}
