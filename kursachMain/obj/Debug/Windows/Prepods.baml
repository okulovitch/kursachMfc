   M S B A M L   `   `   `  ����F  BkursachMain, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:kursachMain.WindowskursachMain.Windows  5   	   )clr-namespace:kursachMainkursachMain  5   	   !    kursachMain.Windows.Prepods   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:kursachMain.Windows     5   	   1kursachMainclr-namespace:kursachMain     5   	   -   5          � Title$  Prepods��5	   	   $	��300��6   $	��600��6&    � 	Resources 5
          kursachMain.kursachDataSet   kursachDataSet ( $преподавателиViewSource �� Source �� Source��%k   &	        &	      7     5   
   6%   �� 5   
    6?   �� *Преподаватели+8   5      .��5      � $
��Left=�6   $	��600��6&    � DataContext# [ 62   ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ Black��6    � Offset$ 0Q�6-   � 5      $ 	#FF701616��6   $ 1Q�61   5      .+�5   
   �� $��Кафедра��6   $
��Left=�6"   $��
10,175,0,0q�6=   $	��Top=�6Q   	 J� RenderTransformOrigin$	 0.627,-0.443&�6i   ���	#FF9E6969$��72��6�   $��24��6�   �� 5   
   $��ФИО��6   $
��Left=�6   $��
11,107,0,0q�69   $	��Top=�6M   $	 0.627,-0.443&�6e   ���	#FF9E6969$��71��6�   $��25��6�   �� 5   
   $��Должность��6   $
��Left=�6$   $��
10,142,0,0q�6?   $	��Top=�6S   $	 0.627,-0.443&�6k   ���	#FF9E6969$��24��6�   �� 5   
   -   5        
 ��Name$
 FIO_txt��5      $
��Left=�6#   $��23��6>   $��
90,107,0,0q�6J    �� TextWrapping$
 Wrap=�6^   $	��Top=�6r   $	��120��6�   $	 -0.11,0.724&�6�   6�   �� 5   
   -   5        $
 
Pulpit_txt��5      $
��Left=�6&   $��23��6A   $��
91,175,0,0q�6M   $
 Wrap=�6a   $	��Top=�6u   $	��120��6�   6�   �� 5   
   -   5        $
 Positin_txt��5      $
��Left=�6'   $��23��6B   $��
91,142,0,0q�6N   $
 Wrap=�6b   $	��Top=�6v   $	��120��6�   �� 5   
   -   5         ��Name$ btn_Save��5      $
��Save��6#   $
��Left=�62   $��
10,212,0,0q�6M   $	��Top=�6a   $��75��6y   ���	#FFB493236�   �� 5   
   -   5        $ btn_PrepodsShowSqlTabl��5      $
��Show��61   $
��Left=�6@   $��
91,212,0,0q�6[   $	��Top=�6o   $	��119��6�   ���	#FF6ABB616�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ PrepodDatabaseGrid��5      $
��Left=�60   $	��124��6K   $��242,107,0,0q�6X   $	��Top=�5       $	��250��6+   $	��328��6:   ��6}   �� 5!      5"      