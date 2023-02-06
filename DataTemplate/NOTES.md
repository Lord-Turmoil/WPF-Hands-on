# Data Template

-----

**Not Compliant**

```C#
public MainWindow()
{
	InitializeComponent();
	for (int i = 0; i < 10;  i++)
	{
		list.Items.Add(new ListBoxItem()
		{
			Content = new TextBlock { Text = i.ToString() }
		});
	}
}
```

