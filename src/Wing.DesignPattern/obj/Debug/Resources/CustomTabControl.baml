   M S B A M L   `   `   `  ����R  NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089H DMahApps.Metro, Version=1.6.1.4, Culture=neutral, PublicKeyToken=null   TabItemPanelBackgroundBrush 	 Gray8  �� Color $  TabItemBackgroundIsSelectedBrush 	 Gray2 % !TabItemBackgroundIsMouseOverBrush 	 Gray5 $  TabItemForegroundIsSelectedBrush  IdealForegroundColor  TabItemSelectorBrush 	 TabControlBackgroundBrush 
 CustomTabItemStyle �� 
TargetType �� Property �� Value �� 
TargetType �Name J� SnapsToDevicePixels ��Name ��Name	 �� Triggers
 P� Property P� Value �� 
TargetName P� 
SourceName  CustomTabControlStyle ��Name K� ZIndex K� IsItemsHost-   'System.Windows.Input.KeyboardNavigation    TabIndex ��Name    DirectionalNavigation    TabNavigation8  2MahApps.Metro.Controls.TransitioningContentControl � UseLayoutRounding-  'MahApps.Metro.Behaviours.ReloadBehavior   OnSelectedTabChanged'    RestartTransitionOnContentChange-  'MahApps.Metro.Controls.TabControlHelper   
Transition   
Transition�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     :x,http://schemas.microsoft.com/winfx/2006/xaml      5      ;controls,http://metro.mahapps.com/winfx/xaml/controls  5      ;
behaviours*http://metro.mahapps.com/winfx/xaml/shared  5      %/	  &	        &	      &	 4     &	 N     &	 h     &		 �     &	
 �     7  7  7  7  &	 �    7 	 7 
 7   �� 5      #  �  6:   �� 5      #  �  6?   �� 5      #  �  6@   �� 5	      #  �  6?   �� 5
      $  	LawnGreen��63   �� 5      $  
WhiteSmoke��68   �� 5      " ��6'   .�5   
   ��  � ��
 ���� 6'   �� 5   
    � ��$ 0q�6,   �� 5   
    � ��$ 0q�6#   �� 5   
    � ��$ 10q�6$   �� 5   
    � ��$	 100��6%   �� 5   
    � ��$ 14(�6%   �� 5   
    � �� 5      �� 5      " ��6"   .R�5      � $ 	PART_Grid��6   #��z��5       . $��0q�5      .+�5      �� $ PART_HeaderContent��6+   #��z��5   +   $��Header��5   +   $��Center=�5   +   # z 5   +   �� 5       $ PART_Selector��6$   $��Bottom=�5!   $   $��4��5"   $   $y�	Collapsed=�5#   $   8��  5$   $   5%      	 5&      P� 5'      
 �@��
IsSelected .  �5(      �� 5)   "   8   � ��6?   �� 5*   "   8   � ��6?   �� 5+   "   $ PART_Selector��6)    � y�$ Visible=�6Z   5-      P� 5.      $ 	PART_Grid��6"   
 �@J�IsMouseOver .  �5/      �� 50   "   8   � ��6?   �� 51   "    �@�Cursor$
 Hand��6;   53      55      57      58      �� 5:      " ��6*   .�5;   
   ��  � ��8   6'   �� 5<   
    �@��TabStripPlacement$	 Top=�6.   �� 5=   
    � ��$ 0q�6,   �� 5>   
    � ��$ 0q�6#   �� 5?   
    � ��$ 0q�6$   �� 5@   
    � ��8  6/   �� 5A   
    � �� 5B      �� 5C      " ��6"   .R�5D      ]� ��. .+�5E      � $ 
HeaderGrid��6   $
��Left=�5F      8�� .+�5H      �� $ HeaderPanel��6'   $��Center=�5I   '   $ 1��5J   '    . $ 1��5L   '   5M      �� 5N      $ ContentPanel��6!   #��z��5O   !   #��z��5P   !   #��z��5Q   !   $ 	Contained=�5R   !   $ 2��5S   !   $ Local=�5T   !   # z 5U   !   ._�5V         .  .  . # z 5Y   C   .��5Z   "   �� $ PART_SelectedContentHost��63    .  #��z��5\   3   $��SelectedContent��5]   3   # z 5^   3   5_      5`      5a      	 5b      P� 5c      
 �@��TabStripPlacement$	 Top=�6?   . �5d      �� $ 
HeaderGrid��6%    � ��$	 Top=�6W   5e      5g      5i      5j      5l      