   M S B A M L   `   `   `  ����E  AWPFLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:WPFLibrary
WPFLibrary  5   	       WPFLibrary.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:WPFLibrary     5   	     � Title$  LibraryManager��5   	   $	��450��6    $	��820��61   $	��450��6A   $	��820��6N   .��5      ��  �� Padding$ 10q�6
   ._�5   
   �  � ColumnDefinitions 5      �� 5      $��3* �6   �� 5      $��2* �6   .+�5      � .+�5      �� $��0��6   .+�5      �� -   5        $��DataContextTitle��5      $
��18px(�6%   $��DemiBold"�65   $��Center=�6K   $	��Top=�6o   $��
40,20,40,0q�6�   $��40��6�   �� 5      -   5        $��DataContextContainer��5      $
��Left=�6d   $	��Top=�6   $��
30,00,30,0q�6�   $	��400��6�   $	��300��6�   $
��Auto��6�   $
��Auto��6�   5      5      �� 5$      $��1��6   .+�5'      �� $��Library Lists��6   $
��Bold"�6%   $��
10 60 0 10q�67   � 5(       5)      �� 5*      $��2* �6   �� 5+      $��* �6   .+�5.      �� $��0��6   .+�5/      �� -   5         ��Name$ UsersButton��5/       $��	10 2 10 2q�6O   $��0��6b   $��Users��6r   �� 50      -   5        $ BooksButton��50      $��	10 0 10 2q�6>   $��0��6Q   $��Books��6a   �� 51      -   5        $ RentalsButton��51      $��	10 0 10 2q�6B   $��0��6U   $��Rentals��6e   52      53      �� 57      -   5         ��Name$ ControlsText��57      $��Managing Data��6&   $
��Bold"�6;   $��10 50 10 10q�6M   � 58       59      �� 5:      $��* �6   �� 5;      $��* �6   .+�5?      �� $��0��6   .+�5@      �� -   5        $ 	AddButton��5@      $��
10 2 20 10q�6:   $��0��6N   $	��Add��6^   �� 5A      -   5        $ 
EditButton��5A   !   $��
10 0 20 10q�6N   $��0��6b   $
��Edit��6r   �� 5B      -	   5        $ RentBookButton��5B   !   $��
10 0 20 10q�6V   $��0��6j   $��	Rent Book��6z   �� 5C      -
   5        $ ReturnBookButton��5C      $��	10 0 20 2q�6H   $��0��6[   $��Return Book��6k   5D      �� 5G      $��1��6   .+�5H      �� -   5        $ RemoveButton��5H   !   $��
10 2 20 10q�6R   $��0��6f   $��Remove��6v   �� 5I      -   5        $ RemoveAllButton��5I      $��	10 0 20 2q�6F   $��0��6Y   $��
Remove All��6i   5J      5K      5M      5N      5O      5P      