 When should I use a struct instead of a class?
ال struct فيه شبه كبير من ال class بس بيختلفوا في كام نقطه 
ال class بتكون reference type اما ال struct بتكون value type ودا بيخلي ال struct اسرع في الاداء لانه بيتخزن في ال stack علي عكس ال class الي بيتخزن في ال heap ودا هيخلي ال struct يبقي احسن في حالة object بسيط 
ال struct مابتدعمش ال inheritance ,ودا من اهم الخصائص في ال oop لكن ممكن نستخدمه في حالة ال object بسيط مش هنحتاج نعمله inheritance 
ممكن نستخدم ال struct لما يكون ال object ثابت مش متغير لان لو عملنا تغير في ال struct بنعمل كائن من جديد مش بنعدل عليه 
