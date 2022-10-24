#include <stdio.h>

int main(){
  char id = 0;
  int pass;
  
  while(id != 'F' && pass != 123){
    printf("Input id: \n");
    fflush(stdin);
    scanf("%c", &id);
    printf("Input pass: \n");
    scanf("%d", &pass);
  }

printf("success\n");
  // if(id == 'F' && pass == 123){
  //   printf("success\n");
  // }else{
  //   printf("not success\n");
  // }

}
