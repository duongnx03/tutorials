#include <stdio.h>

int main(){
  int i;
  for ( i = 0; (i = 20); i++) {
    if (i <= 3) {
     // break;
      continue;
    }
    printf("Hello\n");
  }
}
