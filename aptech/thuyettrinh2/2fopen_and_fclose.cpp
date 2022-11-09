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

