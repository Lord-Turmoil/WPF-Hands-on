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

-----

`ListBox` with similar content.

```xaml
<ListBox x:Name="list">
	<ListBoxItem>
		<StackPanel Orientation="Horizontal">
			<Border
				Width="10"
				Height="10"
				Background="Red" />
			<TextBlock Margin="10,0" Text="Red" />
		</StackPanel>
	</ListBoxItem>
	<ListBoxItem>
		<StackPanel Orientation="Horizontal">
			<Border
				Width="10"
				Height="10"
				Background="Green" />
			<TextBlock Margin="10,0" Text="Green" />
		</StackPanel>
	</ListBoxItem> 
	<ListBoxItem>
		<StackPanel Orientation="Horizontal">
			<Border
				Width="10"
				Height="10"
				Background="Blue" />
			<TextBlock Margin="10,0" Text="Blue" />
		</StackPanel>
	</ListBoxItem>
</ListBox>
```

