   M S B A M L   `   `   `  ����S  ORecorderFileFolderDialog, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:RecorderFileFolderDialogRecorderFileFolderDialog  5   	   %    RecorderFileFolderDialog.Dialog   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   4l&clr-namespace:RecorderFileFolderDialog     5   	     � Title$  Dialog��5   	   $	��100��6   $	��200��6(   $	��200��65   $	��300��6D    � DataContext 5      .   (RecorderFileFolderDialog.DialogViewModel  5   
   .��5	      �  � ShowGridLines .  � ColumnDefinitions 5
   
   �� 5      $��1* �6   �� 5      $��5 �6   �� 5      $��4* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   R� $��0��6   $��0��5      �� 5   
   $��1��6   $��0��5      $��5��5      $��Center=�5      $��Stretch=�5       �� ResizeBehavior$ PreviousAndNext=�5      �� 5   
   $��2��6   $��0��5      �� 5    
   .+�5!      �� -   5        $��Disable��5!      6'   �� 5"      -   5        $��Enable��5"      6&   5#      5&      5'      