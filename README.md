# pract13
**1.	 Изменение свойств объекта класса**

Создать интерфейс, который уведомляет пользователя программы об изменении значений свойства в классе (в котором реализуется данный интерфейс). Сигнатура интерфейса:

```
interface iPropertychanged
{
    event PropertyeventHandler Propertychanged;
}
```

**Делегат имеет следующий вид:**

```
public delegate void PropertyeventHandler (object sender, PropertyeventArgs e);
```

где, в качестве дополнительного параметра (Property­EventArgs) выступает имя изменённого свойства. В методе Main() проверить работоспособность созданного интерфейса.
