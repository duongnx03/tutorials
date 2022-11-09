#include <stdio.h>

int main(){

  struct city
  {
    char name[20];
    int people;
    char shortname[50];
  };

  struct city cities[10];
  int size;
  printf("Input size: \n");
  scanf("%d", &size);

  for (int i = 0; i < size; i++) {
    printf("Input cities[%d]\n", i);
    printf("Input name: \n");
    fflush(stdin);
    gets(cities[i].name);
    printf("Input people: \n");
    scanf("%d", &cities[i].people);
    printf("Input short name: \n");
    fflush(stdin);
    gets(cities[i].shortname);
  }

  int position;
  for (int i = 0; i < size; i++) {
    if (cities[i].people > cities[position]. people) {
      position = i;
    }
  }
  
  printf("----------------\n");
  printf("Name: %s\n", cities[position].name);
  printf("People: %d\n", cities[position].people);
  printf("Shortname: %s\n", cities[position].shortname);

}
