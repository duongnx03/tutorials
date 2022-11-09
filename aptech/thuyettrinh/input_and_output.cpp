#include <stdio.h>
#include <string.h>

int main(){
  char color[20];
  printf("input color: \n");
  //scanf("%s", color);
  fgets(color, 20, stdin);
  //printf("Color: %s\n", color);
  puts(color);
}
