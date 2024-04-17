# maze-quest-game

P.S. При розробці прагнув дотримуватися принципів YANGI та KISS. Тому, я уникав створення надмірно складних систем чи абстракцій, які непотрібні для виконання ТЗ. Доприкладу, скористався FindObjectsOfType<Key>().Length в методі Start() для знаходження кількості ключів які потрібно зібрати, хоча це не найкращий підхід, але це допомогло значно зменшити зайвий код в проекті. Можливо деякі нюанси в коді можуть погіршити гнучкість та підтримуваність у майбутньому, проте ТЗ є кінцевим результатом і проект змінюватися не буде, тому я й уникав зайвої складності і переінжинірингу.
