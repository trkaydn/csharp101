# #Proje 2

```
[16,21,11,8,12,22] -> Merge Sort
```

1. Yukarıdaki dizinin sort türüne göre aşamalarını yazınız.
```
1. Aşama : [16,21,11] ve [8,12,22] olarak parçalanır.
2. Aşama : Sol taraf [16] – [21,11] olarak, sağ taraf [8,12] – [22] olarak tekrar parçalanır.
3. Aşama : Tüm çiftler parçalanır. Sol [16] – [21] – [11] ve sağ [8] – [12] – [22] olur.
4. Aşama : En son parçalanan ikililer sıralanarak tekrar birleştirilir. Sol [16] – [11,21] ve sağ [8] – [12,22] olur.
5. Aşama : Sol ve sağ üçlüleri kendi aralarında sıralanarak tekrar birleştirilir. Sol [11,16,21] ve sağ [8,12,22] olur.
6. Aşama : Son olarak her iki üçlü parça sıralanarak birleştirilir. Sonuç [8,11,12,16,21,22] olarak ortaya çıkar.
```

8. Big-O gösterimini yazınız.
```
O(n)  --> O(6)
```