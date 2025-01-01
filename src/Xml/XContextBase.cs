// ####################################
// ESSE CÓDIGO É GERADO AUTOMATICAMENTE
// ****** NÃO ALTERE ESTE CÓDIGO ******
// ####################################

namespace Conversor.Xml;

public abstract class XContextBase
{
   /// <summary>
   /// Recursively processes an XML node and its children. 
   /// It first checks if the node has children, and if so, 
   /// calls itself on each child node. After processing all 
   /// children, it calls the ProcessNode method on the 
   /// original node.
   /// </summary>
   /// <param name="xnode">The XXmlNode to process.</param>
   public void ProcessNode(XXmlNode xnode)
   {
       if (xnode.ChildNodes != null)
           foreach (var node in xnode.ChildNodes)
               ProcessNode(node);

       ProcessNodeInternal(xnode);
   }

   public void ProcessAttributes(XXmlNode xnode)
   {
       if (xnode.Attributes != null)
           foreach (var attribute in xnode.Attributes)
               ProcessAttributeInternal(xnode, attribute);
   }

   /// <summary>
   /// Recursively processes an XML node and its children. 
   /// It first processes all children, and then calls the 
   /// appropriate ProcessXXXNode method based on the node's name.
   /// </summary>
   /// <param name="node">The XXmlNode to process.</param>
   private void ProcessNodeInternal(XXmlNode xnode)
   {
       if (xnode.ChildNodes != null)
           foreach (var childNode in xnode.ChildNodes)
               ProcessNodeInternal(childNode);

       if (xnode.Code == "")
       {
           string name = xnode.Name!;
           if (name.Contains('.'))
               name = name.Split('.')[0];
           if (name.Contains(':'))
               name = name.Split(':')[1];

           switch(name)
           {
               case "AccessKeyPressedEventArgs":
                   OnAccessKeyPressedEventArgsNode(xnode);
                   break;
               case "AccessText":
                   OnAccessTextNode(xnode);
                   break;
               case "ActiveXHost":
                   OnActiveXHostNode(xnode);
                   break;
               case "AdormedElementPlaceholder":
                   OnAdormedElementPlaceholderNode(xnode);
                   break;
               case "Adorner":
                   OnAdornerNode(xnode);
                   break;
               case "AdornerContainer":
                   OnAdornerContainerNode(xnode);
                   break;
               case "AdornerDecorator":
                   OnAdornerDecoratorNode(xnode);
                   break;
               case "AdornerHitTestResut":
                   OnAdornerHitTestResutNode(xnode);
                   break;
               case "AdornerLayer":
                   OnAdornerLayerNode(xnode);
                   break;
               case "AffineTransform3D":
                   OnAffineTransform3DNode(xnode);
                   break;
               case "AmbientLight":
                   OnAmbientLightNode(xnode);
                   break;
               case "AnchoredBlock":
                   OnAnchoredBlockNode(xnode);
                   break;
               case "Animatable":
                   OnAnimatableNode(xnode);
                   break;
               case "AnimationClock":
                   OnAnimationClockNode(xnode);
                   break;
               case "AnimationTimeline":
                   OnAnimationTimelineNode(xnode);
                   break;
               case "AnnotationDocumemtPagnator":
                   OnAnnotationDocumemtPagnatorNode(xnode);
                   break;
               case "AnnotationService":
                   OnAnnotationServiceNode(xnode);
                   break;
               case "AnnotationStore":
                   OnAnnotationStoreNode(xnode);
                   break;
               case "Application":
                   OnApplicationNode(xnode);
                   break;
               case "ArcSegment":
                   OnArcSegmentNode(xnode);
                   break;
               case "ArrayExtension":
                   OnArrayExtensionNode(xnode);
                   break;
               case "AttachableCollection":
                   OnAttachableCollectionNode(xnode);
                   break;
               case "AttachedPropertyBrowsableAttibute":
                   OnAttachedPropertyBrowsableAttibuteNode(xnode);
                   break;
               case "AttachedPropertyBrowsableForChildrenAttribute":
                   OnAttachedPropertyBrowsableForChildrenAttributeNode(xnode);
                   break;
               case "AttachedPropertyBrowsableForTypeAttribute":
                   OnAttachedPropertyBrowsableForTypeAttributeNode(xnode);
                   break;
               case "AttachedPropertyBrowsableWhenAttributePresentAttribute":
                   OnAttachedPropertyBrowsableWhenAttributePresentAttributeNode(xnode);
                   break;
               case "Attribute":
                   OnAttributeNode(xnode);
                   break;
               case "AutomationPeer":
                   OnAutomationPeerNode(xnode);
                   break;
               case "AxisAngleRotation3D":
                   OnAxisAngleRotation3DNode(xnode);
                   break;
               case "BackEase":
                   OnBackEaseNode(xnode);
                   break;
               case "Baml2006Reader":
                   OnBaml2006ReaderNode(xnode);
                   break;
               case "BaseIListConverter":
                   OnBaseIListConverterNode(xnode);
                   break;
               case "BeginStoryboard":
                   OnBeginStoryboardNode(xnode);
                   break;
               case "Behavior":
                   OnBehaviorNode(xnode);
                   break;
               case "BehaviorCollection":
                   OnBehaviorCollectionNode(xnode);
                   break;
               case "BevelBitmapEffect":
                   OnBevelBitmapEffectNode(xnode);
                   break;
               case "BezierSegment":
                   OnBezierSegmentNode(xnode);
                   break;
               case "Binding":
                   OnBindingNode(xnode);
                   break;
               case "BindingBase":
                   OnBindingBaseNode(xnode);
                   break;
               case "BindingExpression":
                   OnBindingExpressionNode(xnode);
                   break;
               case "BindingExpressionBase":
                   OnBindingExpressionBaseNode(xnode);
                   break;
               case "BindingGroup":
                   OnBindingGroupNode(xnode);
                   break;
               case "BindingListCollectionView":
                   OnBindingListCollectionViewNode(xnode);
                   break;
               case "BitmapCache":
                   OnBitmapCacheNode(xnode);
                   break;
               case "BitmapCacheBrush":
                   OnBitmapCacheBrushNode(xnode);
                   break;
               case "BitmapDecoder":
                   OnBitmapDecoderNode(xnode);
                   break;
               case "BitmapEffect":
                   OnBitmapEffectNode(xnode);
                   break;
               case "BitmapEffectCollection":
                   OnBitmapEffectCollectionNode(xnode);
                   break;
               case "BitmapEffectGroup":
                   OnBitmapEffectGroupNode(xnode);
                   break;
               case "BitmapEffectInput":
                   OnBitmapEffectInputNode(xnode);
                   break;
               case "BitmapEncoder":
                   OnBitmapEncoderNode(xnode);
                   break;
               case "BitmapFrame":
                   OnBitmapFrameNode(xnode);
                   break;
               case "BitmapImage":
                   OnBitmapImageNode(xnode);
                   break;
               case "BitmapMetadata":
                   OnBitmapMetadataNode(xnode);
                   break;
               case "BitmapPalette":
                   OnBitmapPaletteNode(xnode);
                   break;
               case "BitmapSource":
                   OnBitmapSourceNode(xnode);
                   break;
               case "Block":
                   OnBlockNode(xnode);
                   break;
               case "BlockElement":
                   OnBlockElementNode(xnode);
                   break;
               case "BlockUIContainer":
                   OnBlockUIContainerNode(xnode);
                   break;
               case "BlurBitmapEffect":
                   OnBlurBitmapEffectNode(xnode);
                   break;
               case "BlurEffect":
                   OnBlurEffectNode(xnode);
                   break;
               case "BmpBitmapDecoder":
                   OnBmpBitmapDecoderNode(xnode);
                   break;
               case "BmpBitmapEncoder":
                   OnBmpBitmapEncoderNode(xnode);
                   break;
               case "Bold":
                   OnBoldNode(xnode);
                   break;
               case "BooleanAnimationBase":
                   OnBooleanAnimationBaseNode(xnode);
                   break;
               case "BooleanAnimationUsingKeyFrames":
                   OnBooleanAnimationUsingKeyFramesNode(xnode);
                   break;
               case "BooleanKeyFrame":
                   OnBooleanKeyFrameNode(xnode);
                   break;
               case "BooleanKeyFrameCollection":
                   OnBooleanKeyFrameCollectionNode(xnode);
                   break;
               case "BoolIListConverter":
                   OnBoolIListConverterNode(xnode);
                   break;
               case "Border":
                   OnBorderNode(xnode);
                   break;
               case "BounceEase":
                   OnBounceEaseNode(xnode);
                   break;
               case "Brush":
                   OnBrushNode(xnode);
                   break;
               case "BrushValueSerializer":
                   OnBrushValueSerializerNode(xnode);
                   break;
               case "BulletDecorator":
                   OnBulletDecoratorNode(xnode);
                   break;
               case "Button":
                   OnButtonNode(xnode);
                   break;
               case "ButtonAutomationPeer":
                   OnButtonAutomationPeerNode(xnode);
                   break;
               case "ButtonBase":
                   OnButtonBaseNode(xnode);
                   break;
               case "ButtonBaseAutomationPeer":
                   OnButtonBaseAutomationPeerNode(xnode);
                   break;
               case "ByteAnimation":
                   OnByteAnimationNode(xnode);
                   break;
               case "ByteAnimationBase":
                   OnByteAnimationBaseNode(xnode);
                   break;
               case "ByteAnimationUsingKeyFrames":
                   OnByteAnimationUsingKeyFramesNode(xnode);
                   break;
               case "ByteKeyFrame":
                   OnByteKeyFrameNode(xnode);
                   break;
               case "BytekeyFrameCollection":
                   OnBytekeyFrameCollectionNode(xnode);
                   break;
               case "CachedBitmap":
                   OnCachedBitmapNode(xnode);
                   break;
               case "CacheMode":
                   OnCacheModeNode(xnode);
                   break;
               case "CacheModeValueSerializer":
                   OnCacheModeValueSerializerNode(xnode);
                   break;
               case "Calendar":
                   OnCalendarNode(xnode);
                   break;
               case "CalendarAutomationPeer":
                   OnCalendarAutomationPeerNode(xnode);
                   break;
               case "CalendarButton":
                   OnCalendarButtonNode(xnode);
                   break;
               case "CalendarButtonAutomationPeer":
                   OnCalendarButtonAutomationPeerNode(xnode);
                   break;
               case "CalendarDateChangedEventArgs":
                   OnCalendarDateChangedEventArgsNode(xnode);
                   break;
               case "CalendarDayButton":
                   OnCalendarDayButtonNode(xnode);
                   break;
               case "Calendarltem":
                   OnCalendarltemNode(xnode);
                   break;
               case "CalendarModeChangedEventArgs":
                   OnCalendarModeChangedEventArgsNode(xnode);
                   break;
               case "CallMethodAction":
                   OnCallMethodActionNode(xnode);
                   break;
               case "Camera":
                   OnCameraNode(xnode);
                   break;
               case "CanExecuteChangedEventManager":
                   OnCanExecuteChangedEventManagerNode(xnode);
                   break;
               case "CanExecuteRoutedEventArgs":
                   OnCanExecuteRoutedEventArgsNode(xnode);
                   break;
               case "Canvas":
                   OnCanvasNode(xnode);
                   break;
               case "ChangePropertyAction":
                   OnChangePropertyActionNode(xnode);
                   break;
               case "CharAnimationBase":
                   OnCharAnimationBaseNode(xnode);
                   break;
               case "CharAnimationUsingKeyFrame":
                   OnCharAnimationUsingKeyFrameNode(xnode);
                   break;
               case "CharIListConverter":
                   OnCharIListConverterNode(xnode);
                   break;
               case "CharKeyFrame":
                   OnCharKeyFrameNode(xnode);
                   break;
               case "CharKeyFrameCollection":
                   OnCharKeyFrameCollectionNode(xnode);
                   break;
               case "CheckBox":
                   OnCheckBoxNode(xnode);
                   break;
               case "CheckBoxAutomationPeer":
                   OnCheckBoxAutomationPeerNode(xnode);
                   break;
               case "CircleEase":
                   OnCircleEaseNode(xnode);
                   break;
               case "CleanUpVirtualizedItemEventArgs":
                   OnCleanUpVirtualizedItemEventArgsNode(xnode);
                   break;
               case "Clock":
                   OnClockNode(xnode);
                   break;
               case "ClockController":
                   OnClockControllerNode(xnode);
                   break;
               case "ClockGroup":
                   OnClockGroupNode(xnode);
                   break;
               case "CollectionChangedEventManager":
                   OnCollectionChangedEventManagerNode(xnode);
                   break;
               case "CollectionContainer":
                   OnCollectionContainerNode(xnode);
                   break;
               case "CollectionView":
                   OnCollectionViewNode(xnode);
                   break;
               case "CollectionViewSource":
                   OnCollectionViewSourceNode(xnode);
                   break;
               case "ColorAnimation":
                   OnColorAnimationNode(xnode);
                   break;
               case "ColorAnimationBase":
                   OnColorAnimationBaseNode(xnode);
                   break;
               case "ColorAnimationUsingKeyFrames":
                   OnColorAnimationUsingKeyFramesNode(xnode);
                   break;
               case "ColorConvertedBitmap":
                   OnColorConvertedBitmapNode(xnode);
                   break;
               case "ColorConvertedBitmapExtension":
                   OnColorConvertedBitmapExtensionNode(xnode);
                   break;
               case "ColorKeyFrame":
                   OnColorKeyFrameNode(xnode);
                   break;
               case "ColorKeyFrameCollection":
                   OnColorKeyFrameCollectionNode(xnode);
                   break;
               case "ColorDefinition":
                   OnColorDefinitionNode(xnode);
                   break;
               case "CombinedGeometry":
                   OnCombinedGeometryNode(xnode);
                   break;
               case "ComboBox":
                   OnComboBoxNode(xnode);
                   break;
               case "ComboBoxAutomationPeer":
                   OnComboBoxAutomationPeerNode(xnode);
                   break;
               case "ComboBoxltem":
                   OnComboBoxltemNode(xnode);
                   break;
               case "CommonDialog":
                   OnCommonDialogNode(xnode);
                   break;
               case "ComparisonCondition":
                   OnComparisonConditionNode(xnode);
                   break;
               case "ComponentResourceKey":
                   OnComponentResourceKeyNode(xnode);
                   break;
               case "ComponentResourceKeyConverter":
                   OnComponentResourceKeyConverterNode(xnode);
                   break;
               case "CompositionTarget":
                   OnCompositionTargetNode(xnode);
                   break;
               case "ConditionalExpression":
                   OnConditionalExpressionNode(xnode);
                   break;
               case "ConditionBehavior":
                   OnConditionBehaviorNode(xnode);
                   break;
               case "ConditionCollection":
                   OnConditionCollectionNode(xnode);
                   break;
               case "ContainerUIElement3D":
                   OnContainerUIElement3DNode(xnode);
                   break;
               case "ContainerVisual":
                   OnContainerVisualNode(xnode);
                   break;
               case "ContentControl":
                   OnContentControlNode(xnode);
                   break;
               case "ContentElement":
                   OnContentElementNode(xnode);
                   break;
               case "ContentElementAutomationPeer":
                   OnContentElementAutomationPeerNode(xnode);
                   break;
               case "ContentLocator":
                   OnContentLocatorNode(xnode);
                   break;
               case "ContentocatorBase":
                   OnContentocatorBaseNode(xnode);
                   break;
               case "ContentLocatorGroup":
                   OnContentLocatorGroupNode(xnode);
                   break;
               case "ContentPosition":
                   OnContentPositionNode(xnode);
                   break;
               case "ContentPresenter":
                   OnContentPresenterNode(xnode);
                   break;
               case "ContentTextAutomationPeer":
                   OnContentTextAutomationPeerNode(xnode);
                   break;
               case "ContextMenu":
                   OnContextMenuNode(xnode);
                   break;
               case "ContextMenuAutomationPeer":
                   OnContextMenuAutomationPeerNode(xnode);
                   break;
               case "ContextMenuEventArgs":
                   OnContextMenuEventArgsNode(xnode);
                   break;
               case "Control":
                   OnControlNode(xnode);
                   break;
               case "ControllableStoryboardAction":
                   OnControllableStoryboardActionNode(xnode);
                   break;
               case "ControlStoryboardAction":
                   OnControlStoryboardActionNode(xnode);
                   break;
               case "ControlTemplate":
                   OnControlTemplateNode(xnode);
                   break;
               case "CroppedBitmap":
                   OnCroppedBitmapNode(xnode);
                   break;
               case "CubicEase":
                   OnCubicEaseNode(xnode);
                   break;
               case "CurrentChangedEventManager":
                   OnCurrentChangedEventManagerNode(xnode);
                   break;
               case "CurrentChangingEventManager":
                   OnCurrentChangingEventManagerNode(xnode);
                   break;
               case "D3DImage":
                   OnD3DImageNode(xnode);
                   break;
               case "DashStyle":
                   OnDashStyleNode(xnode);
                   break;
               case "DataChangedEventManager":
                   OnDataChangedEventManagerNode(xnode);
                   break;
               case "DataErrorValidationRule":
                   OnDataErrorValidationRuleNode(xnode);
                   break;
               case "DataGrid":
                   OnDataGridNode(xnode);
                   break;
               case "DataGridAutomationPeer":
                   OnDataGridAutomationPeerNode(xnode);
                   break;
               case "DataGridBoundColumn":
                   OnDataGridBoundColumnNode(xnode);
                   break;
               case "DataGridCell":
                   OnDataGridCellNode(xnode);
                   break;
               case "DataGridCellAutomationPeer":
                   OnDataGridCellAutomationPeerNode(xnode);
                   break;
               case "DataGridCellItemAutomationPeer":
                   OnDataGridCellItemAutomationPeerNode(xnode);
                   break;
               case "DataGridCellsPanel":
                   OnDataGridCellsPanelNode(xnode);
                   break;
               case "DataGridCellsPresenter":
                   OnDataGridCellsPresenterNode(xnode);
                   break;
               case "DataGridCheckBoxColumn":
                   OnDataGridCheckBoxColumnNode(xnode);
                   break;
               case "DataGridColumn":
                   OnDataGridColumnNode(xnode);
                   break;
               case "DataGridColumnEventArgs":
                   OnDataGridColumnEventArgsNode(xnode);
                   break;
               case "DataGridColumnHeader":
                   OnDataGridColumnHeaderNode(xnode);
                   break;
               case "DataGridColumnHeaderAutomationPeer":
                   OnDataGridColumnHeaderAutomationPeerNode(xnode);
                   break;
               case "DataGridColumnHeaderItemAutomationPeer":
                   OnDataGridColumnHeaderItemAutomationPeerNode(xnode);
                   break;
               case "DataGridColumnHeadersPresenter":
                   OnDataGridColumnHeadersPresenterNode(xnode);
                   break;
               case "DataGridColumnHeadersPresenterAutomationPeer":
                   OnDataGridColumnHeadersPresenterAutomationPeerNode(xnode);
                   break;
               case "DataGridColumnReorderingEventArgs":
                   OnDataGridColumnReorderingEventArgsNode(xnode);
                   break;
               case "DataGridComboBoxColumn":
                   OnDataGridComboBoxColumnNode(xnode);
                   break;
               case "DataGridDetailsPresenter":
                   OnDataGridDetailsPresenterNode(xnode);
                   break;
               case "DataGridDetailsPresenterAutomationPeer":
                   OnDataGridDetailsPresenterAutomationPeerNode(xnode);
                   break;
               case "DataGridHyperlinkColumn":
                   OnDataGridHyperlinkColumnNode(xnode);
                   break;
               case "DataGridItemAutomationPeer":
                   OnDataGridItemAutomationPeerNode(xnode);
                   break;
               case "DataGridRow":
                   OnDataGridRowNode(xnode);
                   break;
               case "DataGridRowAutomationPeer":
                   OnDataGridRowAutomationPeerNode(xnode);
                   break;
               case "DataGridRowHeader":
                   OnDataGridRowHeaderNode(xnode);
                   break;
               case "DataGridRowHeaderAutomationPeer":
                   OnDataGridRowHeaderAutomationPeerNode(xnode);
                   break;
               case "DataGridRowsPresenter":
                   OnDataGridRowsPresenterNode(xnode);
                   break;
               case "DataGridSortingEventArgs":
                   OnDataGridSortingEventArgsNode(xnode);
                   break;
               case "DataGridTemplateColumn":
                   OnDataGridTemplateColumnNode(xnode);
                   break;
               case "DataGridTextColumn":
                   OnDataGridTextColumnNode(xnode);
                   break;
               case "DataObjectCopyingEventArgs":
                   OnDataObjectCopyingEventArgsNode(xnode);
                   break;
               case "DataObjectEventArgs":
                   OnDataObjectEventArgsNode(xnode);
                   break;
               case "DataObjectPastingEventArgs":
                   OnDataObjectPastingEventArgsNode(xnode);
                   break;
               case "DataObjectSettingDataEventArgs":
                   OnDataObjectSettingDataEventArgsNode(xnode);
                   break;
               case "DataSourceProvider":
                   OnDataSourceProviderNode(xnode);
                   break;
               case "DataStateBehavior":
                   OnDataStateBehaviorNode(xnode);
                   break;
               case "DataStoreChangedTrigger":
                   OnDataStoreChangedTriggerNode(xnode);
                   break;
               case "DataTemplate":
                   OnDataTemplateNode(xnode);
                   break;
               case "DataTemplateKey":
                   OnDataTemplateKeyNode(xnode);
                   break;
               case "DataTransferEventArgs":
                   OnDataTransferEventArgsNode(xnode);
                   break;
               case "DataTrigger":
                   OnDataTriggerNode(xnode);
                   break;
               case "DatePicker":
                   OnDatePickerNode(xnode);
                   break;
               case "DatePickerAutomationPeer":
                   OnDatePickerAutomationPeerNode(xnode);
                   break;
               case "DatePickerTextBox":
                   OnDatePickerTextBoxNode(xnode);
                   break;
               case "DateTimeAutomationPeer":
                   OnDateTimeAutomationPeerNode(xnode);
                   break;
               case "DateTimeValueSerializer":
                   OnDateTimeValueSerializerNode(xnode);
                   break;
               case "DecimalAnimation":
                   OnDecimalAnimationNode(xnode);
                   break;
               case "DecimalAnimationBase":
                   OnDecimalAnimationBaseNode(xnode);
                   break;
               case "DecimalAnimationUsingKeyFrames":
                   OnDecimalAnimationUsingKeyFramesNode(xnode);
                   break;
               case "DecimalKeyFrame":
                   OnDecimalKeyFrameNode(xnode);
                   break;
               case "DecimalKeyFrameCollection":
                   OnDecimalKeyFrameCollectionNode(xnode);
                   break;
               case "Decorator":
                   OnDecoratorNode(xnode);
                   break;
               case "DefinitionBase":
                   OnDefinitionBaseNode(xnode);
                   break;
               case "DependencyObject":
                   OnDependencyObjectNode(xnode);
                   break;
               case "DiffuseMaterial":
                   OnDiffuseMaterialNode(xnode);
                   break;
               case "DirectionalLight":
                   OnDirectionalLightNode(xnode);
                   break;
               case "DiscreteBooleanKeyFrame":
                   OnDiscreteBooleanKeyFrameNode(xnode);
                   break;
               case "DiscreteByteKeyFrame":
                   OnDiscreteByteKeyFrameNode(xnode);
                   break;
               case "DiscreteCharKevFrame":
                   OnDiscreteCharKevFrameNode(xnode);
                   break;
               case "DiscreteColorKeyFrame":
                   OnDiscreteColorKeyFrameNode(xnode);
                   break;
               case "DiscreteDecimalKeyFrame":
                   OnDiscreteDecimalKeyFrameNode(xnode);
                   break;
               case "DiscreteDoubleKeyFrame":
                   OnDiscreteDoubleKeyFrameNode(xnode);
                   break;
               case "DiscreteInt16KevFrame":
                   OnDiscreteInt16KevFrameNode(xnode);
                   break;
               case "DiscreteInt32KeyFrame":
                   OnDiscreteInt32KeyFrameNode(xnode);
                   break;
               case "Discretent64KeyFrame":
                   OnDiscretent64KeyFrameNode(xnode);
                   break;
               case "DiscretelMatrixKeyFrame":
                   OnDiscretelMatrixKeyFrameNode(xnode);
                   break;
               case "DiscereteObjectKeyFrame":
                   OnDiscereteObjectKeyFrameNode(xnode);
                   break;
               case "DiscretePoint3DKeyFrame":
                   OnDiscretePoint3DKeyFrameNode(xnode);
                   break;
               case "DiscretePointKeyFrame":
                   OnDiscretePointKeyFrameNode(xnode);
                   break;
               case "DiscreteQuaternionKeyFrame":
                   OnDiscreteQuaternionKeyFrameNode(xnode);
                   break;
               case "DiscreteRectKeyFrame":
                   OnDiscreteRectKeyFrameNode(xnode);
                   break;
               case "DiscreteRotation3DKeyFramne":
                   OnDiscreteRotation3DKeyFramneNode(xnode);
                   break;
               case "DiscreteSingleKeyFrame":
                   OnDiscreteSingleKeyFrameNode(xnode);
                   break;
               case "DiscreteSizeKeyFrame":
                   OnDiscreteSizeKeyFrameNode(xnode);
                   break;
               case "DiscreteStringKeyFrame":
                   OnDiscreteStringKeyFrameNode(xnode);
                   break;
               case "DiscreteThicknessKeyFrame":
                   OnDiscreteThicknessKeyFrameNode(xnode);
                   break;
               case "DiscreteVector3DKeyFrame":
                   OnDiscreteVector3DKeyFrameNode(xnode);
                   break;
               case "DiscreteVectorKeyFrame":
                   OnDiscreteVectorKeyFrameNode(xnode);
                   break;
               case "DispatcherEventArgs":
                   OnDispatcherEventArgsNode(xnode);
                   break;
               case "DispatcherFrame":
                   OnDispatcherFrameNode(xnode);
                   break;
               case "DispatcherObject":
                   OnDispatcherObjectNode(xnode);
                   break;
               case "DispatcherOperation":
                   OnDispatcherOperationNode(xnode);
                   break;
               case "DispatcherUnhandledExceptionEventArgs":
                   OnDispatcherUnhandledExceptionEventArgsNode(xnode);
                   break;
               case "DispatcherUnhandledExceptionFilterEventArgs":
                   OnDispatcherUnhandledExceptionFilterEventArgsNode(xnode);
                   break;
               case "DockPanel":
                   OnDockPanelNode(xnode);
                   break;
               case "DocumentAutomationPeer":
                   OnDocumentAutomationPeerNode(xnode);
                   break;
               case "DocumentViewerAutomationPeer":
                   OnDocumentViewerAutomationPeerNode(xnode);
                   break;
               case "DocumentPageView":
                   OnDocumentPageViewNode(xnode);
                   break;
               case "DocumentPageViewAutomationPeer":
                   OnDocumentPageViewAutomationPeerNode(xnode);
                   break;
               case "DocumentPaginator":
                   OnDocumentPaginatorNode(xnode);
                   break;
               case "DocumentReference":
                   OnDocumentReferenceNode(xnode);
                   break;
               case "DocumentViewer":
                   OnDocumentViewerNode(xnode);
                   break;
               case "DocumentViewerBaseAutomationPeer":
                   OnDocumentViewerBaseAutomationPeerNode(xnode);
                   break;
               case "DoCumentViewerBase":
                   OnDoCumentViewerBaseNode(xnode);
                   break;
               case "DoubleAnimation":
                   OnDoubleAnimationNode(xnode);
                   break;
               case "DoubleAnimationBase":
                   OnDoubleAnimationBaseNode(xnode);
                   break;
               case "DoubleAmimationUsingKevFrames":
                   OnDoubleAmimationUsingKevFramesNode(xnode);
                   break;
               case "DoubleAnimationsingPath":
                   OnDoubleAnimationsingPathNode(xnode);
                   break;
               case "DoubleCollection":
                   OnDoubleCollectionNode(xnode);
                   break;
               case "DoubleCollectionValueSenalizer":
                   OnDoubleCollectionValueSenalizerNode(xnode);
                   break;
               case "DoubleIListConverter":
                   OnDoubleIListConverterNode(xnode);
                   break;
               case "DoubleKeyFrame":
                   OnDoubleKeyFrameNode(xnode);
                   break;
               case "DoubleKeyFrameCollection":
                   OnDoubleKeyFrameCollectionNode(xnode);
                   break;
               case "DragCompletedEventArgs":
                   OnDragCompletedEventArgsNode(xnode);
                   break;
               case "DragDeltaEventArgs":
                   OnDragDeltaEventArgsNode(xnode);
                   break;
               case "DragEventArgs":
                   OnDragEventArgsNode(xnode);
                   break;
               case "DragStartedEventArgs":
                   OnDragStartedEventArgsNode(xnode);
                   break;
               case "Drawing":
                   OnDrawingNode(xnode);
                   break;
               case "DrawingBrush":
                   OnDrawingBrushNode(xnode);
                   break;
               case "DrawingCollection":
                   OnDrawingCollectionNode(xnode);
                   break;
               case "DrawingContext":
                   OnDrawingContextNode(xnode);
                   break;
               case "DrawingGroup":
                   OnDrawingGroupNode(xnode);
                   break;
               case "DrawingImage":
                   OnDrawingImageNode(xnode);
                   break;
               case "DrawingVisual":
                   OnDrawingVisualNode(xnode);
                   break;
               case "DropShadowBitmapEffect":
                   OnDropShadowBitmapEffectNode(xnode);
                   break;
               case "DropShadowEffect":
                   OnDropShadowEffectNode(xnode);
                   break;
               case "DynamicDocumentPaginator":
                   OnDynamicDocumentPaginatorNode(xnode);
                   break;
               case "DynamicRenderer":
                   OnDynamicRendererNode(xnode);
                   break;
               case "DynamicResourceExtension":
                   OnDynamicResourceExtensionNode(xnode);
                   break;
               case "EasingByteKeyFrame":
                   OnEasingByteKeyFrameNode(xnode);
                   break;
               case "EasingColorKeyFrame":
                   OnEasingColorKeyFrameNode(xnode);
                   break;
               case "EasingDecimalKeyFrame":
                   OnEasingDecimalKeyFrameNode(xnode);
                   break;
               case "EasingDoubleKeyFrame":
                   OnEasingDoubleKeyFrameNode(xnode);
                   break;
               case "EasingFunctionBase":
                   OnEasingFunctionBaseNode(xnode);
                   break;
               case "EasingInt16KeyFrame":
                   OnEasingInt16KeyFrameNode(xnode);
                   break;
               case "EasingInt32KeyFrame":
                   OnEasingInt32KeyFrameNode(xnode);
                   break;
               case "Easinglnt64KeyFrame":
                   OnEasinglnt64KeyFrameNode(xnode);
                   break;
               case "EasingPoint3DKeyFrame":
                   OnEasingPoint3DKeyFrameNode(xnode);
                   break;
               case "EasingPointKeyFrame":
                   OnEasingPointKeyFrameNode(xnode);
                   break;
               case "EasingQuaternionKeyFrame":
                   OnEasingQuaternionKeyFrameNode(xnode);
                   break;
               case "EasingRectKeyFrame":
                   OnEasingRectKeyFrameNode(xnode);
                   break;
               case "EasingRotation3DKeyFrame":
                   OnEasingRotation3DKeyFrameNode(xnode);
                   break;
               case "EasingSingleKeyFrame":
                   OnEasingSingleKeyFrameNode(xnode);
                   break;
               case "EasingSizeKeyFranme":
                   OnEasingSizeKeyFranmeNode(xnode);
                   break;
               case "EasingThicknessKeyFrame":
                   OnEasingThicknessKeyFrameNode(xnode);
                   break;
               case "EasıngVector3DKeyFrame":
                   OnEasıngVector3DKeyFrameNode(xnode);
                   break;
               case "EasingVectorKeyFrame":
                   OnEasingVectorKeyFrameNode(xnode);
                   break;
               case "Effect":
                   OnEffectNode(xnode);
                   break;
               case "ElasticEase":
                   OnElasticEaseNode(xnode);
                   break;
               case "Ellipse":
                   OnEllipseNode(xnode);
                   break;
               case "EllipseGeometry":
                   OnEllipseGeometryNode(xnode);
                   break;
               case "EllipseStylusShape":
                   OnEllipseStylusShapeNode(xnode);
                   break;
               case "EmbossBitmapEffect":
                   OnEmbossBitmapEffectNode(xnode);
                   break;
               case "EmissiveMaterial":
                   OnEmissiveMaterialNode(xnode);
                   break;
               case "ErrorsChangedEventManager":
                   OnErrorsChangedEventManagerNode(xnode);
                   break;
               case "EventArgs":
                   OnEventArgsNode(xnode);
                   break;
               case "EventSetter":
                   OnEventSetterNode(xnode);
                   break;
               case "EventTrigger":
                   OnEventTriggerNode(xnode);
                   break;
               case "EventTriggerBase":
                   OnEventTriggerBaseNode(xnode);
                   break;
               case "Exception":
                   OnExceptionNode(xnode);
                   break;
               case "ExceptionRoutedEventArgs":
                   OnExceptionRoutedEventArgsNode(xnode);
                   break;
               case "ExceptionValidationRule":
                   OnExceptionValidationRuleNode(xnode);
                   break;
               case "ExecutedRoutedEventArgs":
                   OnExecutedRoutedEventArgsNode(xnode);
                   break;
               case "Expander":
                   OnExpanderNode(xnode);
                   break;
               case "ExpanderAutomationPeer":
                   OnExpanderAutomationPeerNode(xnode);
                   break;
               case "ExponentialEase":
                   OnExponentialEaseNode(xnode);
                   break;
               case "Expression":
                   OnExpressionNode(xnode);
                   break;
               case "ExpressionConverter":
                   OnExpressionConverterNode(xnode);
                   break;
               case "ExtendedVisualStateManager":
                   OnExtendedVisualStateManagerNode(xnode);
                   break;
               case "Figure":
                   OnFigureNode(xnode);
                   break;
               case "FigureStructure":
                   OnFigureStructureNode(xnode);
                   break;
               case "FileDialog":
                   OnFileDialogNode(xnode);
                   break;
               case "FixedDocument":
                   OnFixedDocumentNode(xnode);
                   break;
               case "FixedDocumentSequence":
                   OnFixedDocumentSequenceNode(xnode);
                   break;
               case "FixedPage":
                   OnFixedPageNode(xnode);
                   break;
               case "FixedPageAutomationPeer":
                   OnFixedPageAutomationPeerNode(xnode);
                   break;
               case "Floater":
                   OnFloaterNode(xnode);
                   break;
               case "FlowDocument":
                   OnFlowDocumentNode(xnode);
                   break;
               case "FlowDocumentPageViewer":
                   OnFlowDocumentPageViewerNode(xnode);
                   break;
               case "FlowDocumentPageViewerAutomationPeer":
                   OnFlowDocumentPageViewerAutomationPeerNode(xnode);
                   break;
               case "FlowDocumentReader":
                   OnFlowDocumentReaderNode(xnode);
                   break;
               case "FlowDocumentReaderAutomationPeer":
                   OnFlowDocumentReaderAutomationPeerNode(xnode);
                   break;
               case "FlowDocumentScrollViewer":
                   OnFlowDocumentScrollViewerNode(xnode);
                   break;
               case "FlowDocumentScrollViewerAutomationPeer":
                   OnFlowDocumentScrollViewerAutomationPeerNode(xnode);
                   break;
               case "FluidMoveBehavior":
                   OnFluidMoveBehaviorNode(xnode);
                   break;
               case "FluidMoveBehaviorBase":
                   OnFluidMoveBehaviorBaseNode(xnode);
                   break;
               case "FluidMoveSetTagBehavior":
                   OnFluidMoveSetTagBehaviorNode(xnode);
                   break;
               case "FontFamilyValueSerializer":
                   OnFontFamilyValueSerializerNode(xnode);
                   break;
               case "FormatConvertedBitmap":
                   OnFormatConvertedBitmapNode(xnode);
                   break;
               case "Frame":
                   OnFrameNode(xnode);
                   break;
               case "FrameAutomationPeer":
                   OnFrameAutomationPeerNode(xnode);
                   break;
               case "FrameworkContentElement":
                   OnFrameworkContentElementNode(xnode);
                   break;
               case "FrameworkContentElementAutomationPeer":
                   OnFrameworkContentElementAutomationPeerNode(xnode);
                   break;
               case "FrameworkElement":
                   OnFrameworkElementNode(xnode);
                   break;
               case "FrameworkElementAutomationPeer":
                   OnFrameworkElementAutomationPeerNode(xnode);
                   break;
               case "FrameworkPropertyMetadata":
                   OnFrameworkPropertyMetadataNode(xnode);
                   break;
               case "FrameworkRichTextComposition":
                   OnFrameworkRichTextCompositionNode(xnode);
                   break;
               case "FrameworkTemplate":
                   OnFrameworkTemplateNode(xnode);
                   break;
               case "FrameworkTextComposition":
                   OnFrameworkTextCompositionNode(xnode);
                   break;
               case "Freezable":
                   OnFreezableNode(xnode);
                   break;
               case "FreezableCollection":
                   OnFreezableCollectionNode(xnode);
                   break;
               case "GeneralTransform":
                   OnGeneralTransformNode(xnode);
                   break;
               case "GeneralTransform2DTo3D":
                   OnGeneralTransform2DTo3DNode(xnode);
                   break;
               case "GeneralTransform3D":
                   OnGeneralTransform3DNode(xnode);
                   break;
               case "GeneralTransform3DCollection":
                   OnGeneralTransform3DCollectionNode(xnode);
                   break;
               case "GeneralTransform3DGroup":
                   OnGeneralTransform3DGroupNode(xnode);
                   break;
               case "GeneralTransform3DTo2D":
                   OnGeneralTransform3DTo2DNode(xnode);
                   break;
               case "GeneralTransformCollection":
                   OnGeneralTransformCollectionNode(xnode);
                   break;
               case "GeneralTransformGroup":
                   OnGeneralTransformGroupNode(xnode);
                   break;
               case "GenericRootAutomationPeer":
                   OnGenericRootAutomationPeerNode(xnode);
                   break;
               case "Geometry":
                   OnGeometryNode(xnode);
                   break;
               case "Geometry3D":
                   OnGeometry3DNode(xnode);
                   break;
               case "GeometryCollection":
                   OnGeometryCollectionNode(xnode);
                   break;
               case "GeometryDrawing":
                   OnGeometryDrawingNode(xnode);
                   break;
               case "GeometryGroup":
                   OnGeometryGroupNode(xnode);
                   break;
               case "GeometryHitTestParameters":
                   OnGeometryHitTestParametersNode(xnode);
                   break;
               case "GeometryHitTestResult":
                   OnGeometryHitTestResultNode(xnode);
                   break;
               case "GeometryModel3D":
                   OnGeometryModel3DNode(xnode);
                   break;
               case "GeometryValueSenalizer":
                   OnGeometryValueSenalizerNode(xnode);
                   break;
               case "GestureRecognizer":
                   OnGestureRecognizerNode(xnode);
                   break;
               case "GifBitmapDecoder":
                   OnGifBitmapDecoderNode(xnode);
                   break;
               case "GifBitmapEncoder":
                   OnGifBitmapEncoderNode(xnode);
                   break;
               case "GiveFeedbackEventArgs":
                   OnGiveFeedbackEventArgsNode(xnode);
                   break;
               case "GlyphRunDrawing":
                   OnGlyphRunDrawingNode(xnode);
                   break;
               case "Glyphs":
                   OnGlyphsNode(xnode);
                   break;
               case "GoToStateAction":
                   OnGoToStateActionNode(xnode);
                   break;
               case "GradientBrush":
                   OnGradientBrushNode(xnode);
                   break;
               case "GradientStop":
                   OnGradientStopNode(xnode);
                   break;
               case "GradientStopCollection":
                   OnGradientStopCollectionNode(xnode);
                   break;
               case "Grid":
                   OnGridNode(xnode);
                   break;
               case "GridSplitter":
                   OnGridSplitterNode(xnode);
                   break;
               case "GridSplitterAutomationPeer":
                   OnGridSplitterAutomationPeerNode(xnode);
                   break;
               case "GridView":
                   OnGridViewNode(xnode);
                   break;
               case "GridViewCellAutomationPeer":
                   OnGridViewCellAutomationPeerNode(xnode);
                   break;
               case "GridViewColumn":
                   OnGridViewColumnNode(xnode);
                   break;
               case "GridViewColumnHeader":
                   OnGridViewColumnHeaderNode(xnode);
                   break;
               case "GidViewColumnHeaderAutomationPeer":
                   OnGidViewColumnHeaderAutomationPeerNode(xnode);
                   break;
               case "GridViewHeaderRowPresenter":
                   OnGridViewHeaderRowPresenterNode(xnode);
                   break;
               case "GridViewHeaderRowPresenterAutomationPeer":
                   OnGridViewHeaderRowPresenterAutomationPeerNode(xnode);
                   break;
               case "GridViewItemAutomationPeer":
                   OnGridViewItemAutomationPeerNode(xnode);
                   break;
               case "GridViewRowPresenter":
                   OnGridViewRowPresenterNode(xnode);
                   break;
               case "GridViewRowPresenterBase":
                   OnGridViewRowPresenterBaseNode(xnode);
                   break;
               case "GroupBox":
                   OnGroupBoxNode(xnode);
                   break;
               case "GroupBoXAutomationPeer":
                   OnGroupBoXAutomationPeerNode(xnode);
                   break;
               case "GroupDescription":
                   OnGroupDescriptionNode(xnode);
                   break;
               case "Groupltem":
                   OnGroupltemNode(xnode);
                   break;
               case "GroupItemAutomationPeer":
                   OnGroupItemAutomationPeerNode(xnode);
                   break;
               case "GuidelineSet":
                   OnGuidelineSetNode(xnode);
                   break;
               case "HeaderedContentControl":
                   OnHeaderedContentControlNode(xnode);
                   break;
               case "HeaderedItemsControl":
                   OnHeaderedItemsControlNode(xnode);
                   break;
               case "HierarchicalDataTemplate":
                   OnHierarchicalDataTemplateNode(xnode);
                   break;
               case "HitTestParameters":
                   OnHitTestParametersNode(xnode);
                   break;
               case "HitTestParameters3D":
                   OnHitTestParameters3DNode(xnode);
                   break;
               case "HitTestResult":
                   OnHitTestResultNode(xnode);
                   break;
               case "HostVisual":
                   OnHostVisualNode(xnode);
                   break;
               case "HwndHost":
                   OnHwndHostNode(xnode);
                   break;
               case "HwndSource":
                   OnHwndSourceNode(xnode);
                   break;
               case "HwndTarget":
                   OnHwndTargetNode(xnode);
                   break;
               case "Hperlınk":
                   OnHperlınkNode(xnode);
                   break;
               case "HyperlinkAutomationPeer":
                   OnHyperlinkAutomationPeerNode(xnode);
                   break;
               case "IconBitmapDecoder":
                   OnIconBitmapDecoderNode(xnode);
                   break;
               case "Image":
                   OnImageNode(xnode);
                   break;
               case "ImageAutomationPeer":
                   OnImageAutomationPeerNode(xnode);
                   break;
               case "TmageBrush":
                   OnTmageBrushNode(xnode);
                   break;
               case "ImageDrawing":
                   OnImageDrawingNode(xnode);
                   break;
               case "Imageetadata":
                   OnImageetadataNode(xnode);
                   break;
               case "ImageSource":
                   OnImageSourceNode(xnode);
                   break;
               case "ImageSourcealueSerializer":
                   OnImageSourcealueSerializerNode(xnode);
                   break;
               case "IncrementalHitTester":
                   OnIncrementalHitTesterNode(xnode);
                   break;
               case "IncrementalLassoHitTester":
                   OnIncrementalLassoHitTesterNode(xnode);
                   break;
               case "IncrementalStrokehHitTester":
                   OnIncrementalStrokehHitTesterNode(xnode);
                   break;
               case "InkCanvas":
                   OnInkCanvasNode(xnode);
                   break;
               case "InkCanvasAutomationPeer":
                   OnInkCanvasAutomationPeerNode(xnode);
                   break;
               case "InkCanvasGestureEventArgs":
                   OnInkCanvasGestureEventArgsNode(xnode);
                   break;
               case "InkCanvasStrokeCollectedEventArgs":
                   OnInkCanvasStrokeCollectedEventArgsNode(xnode);
                   break;
               case "InkPresenter":
                   OnInkPresenterNode(xnode);
                   break;
               case "InkPresenterAutomationPeer":
                   OnInkPresenterAutomationPeerNode(xnode);
                   break;
               case "Inline":
                   OnInlineNode(xnode);
                   break;
               case "InlineUIContainer":
                   OnInlineUIContainerNode(xnode);
                   break;
               case "InPlaceBitmapMetadata":
                   OnInPlaceBitmapMetadataNode(xnode);
                   break;
               case "InputBindıng":
                   OnInputBindıngNode(xnode);
                   break;
               case "InputDevice":
                   OnInputDeviceNode(xnode);
                   break;
               case "InputEventArgs":
                   OnInputEventArgsNode(xnode);
                   break;
               case "InputGesture":
                   OnInputGestureNode(xnode);
                   break;
               case "InputanguageChangedEventArgs":
                   OnInputanguageChangedEventArgsNode(xnode);
                   break;
               case "InputLanguageChangingEventArgs":
                   OnInputLanguageChangingEventArgsNode(xnode);
                   break;
               case "InputanguageEventArgs":
                   OnInputanguageEventArgsNode(xnode);
                   break;
               case "InputLanguageManager":
                   OnInputLanguageManagerNode(xnode);
                   break;
               case "InputManager":
                   OnInputManagerNode(xnode);
                   break;
               case "InputMethod":
                   OnInputMethodNode(xnode);
                   break;
               case "Int16Animation":
                   OnInt16AnimationNode(xnode);
                   break;
               case "Int16AnimationBase":
                   OnInt16AnimationBaseNode(xnode);
                   break;
               case "Int16AnimationBaseUsingKeyFrames":
                   OnInt16AnimationBaseUsingKeyFramesNode(xnode);
                   break;
               case "Int16KeyFrame":
                   OnInt16KeyFrameNode(xnode);
                   break;
               case "Int16KeyFrameCollection":
                   OnInt16KeyFrameCollectionNode(xnode);
                   break;
               case "Int32Animation":
                   OnInt32AnimationNode(xnode);
                   break;
               case "Int32AnimationBase":
                   OnInt32AnimationBaseNode(xnode);
                   break;
               case "Int32AnimationUsingKeyFrames":
                   OnInt32AnimationUsingKeyFramesNode(xnode);
                   break;
               case "Int32Collection":
                   OnInt32CollectionNode(xnode);
                   break;
               case "Int32CollecionValueSerializer":
                   OnInt32CollecionValueSerializerNode(xnode);
                   break;
               case "Int32KeyFrame":
                   OnInt32KeyFrameNode(xnode);
                   break;
               case "Int32KeyFrameCollection":
                   OnInt32KeyFrameCollectionNode(xnode);
                   break;
               case "Int32RectValueSernalizer":
                   OnInt32RectValueSernalizerNode(xnode);
                   break;
               case "Int64Animation":
                   OnInt64AnimationNode(xnode);
                   break;
               case "Int64AnimationBase":
                   OnInt64AnimationBaseNode(xnode);
                   break;
               case "Int64AnimationUsingKeyFrames":
                   OnInt64AnimationUsingKeyFramesNode(xnode);
                   break;
               case "Int64KevFrame":
                   OnInt64KevFrameNode(xnode);
                   break;
               case "Int64KevFrameCollection":
                   OnInt64KevFrameCollectionNode(xnode);
                   break;
               case "InteropBitmap":
                   OnInteropBitmapNode(xnode);
                   break;
               case "InvokeCommandAction":
                   OnInvokeCommandActionNode(xnode);
                   break;
               case "Italic":
                   OnItalicNode(xnode);
                   break;
               case "ItemAutomationPeer":
                   OnItemAutomationPeerNode(xnode);
                   break;
               case "ItemCollection":
                   OnItemCollectionNode(xnode);
                   break;
               case "ItemContainerTernplate":
                   OnItemContainerTernplateNode(xnode);
                   break;
               case "ItemContainerTemplateKey":
                   OnItemContainerTemplateKeyNode(xnode);
                   break;
               case "ItemsControl":
                   OnItemsControlNode(xnode);
                   break;
               case "ItemsControlAutomationPeer":
                   OnItemsControlAutomationPeerNode(xnode);
                   break;
               case "ItemsPanelTernplate":
                   OnItemsPanelTernplateNode(xnode);
                   break;
               case "ItemsPresenter":
                   OnItemsPresenterNode(xnode);
                   break;
               case "JournalEntry":
                   OnJournalEntryNode(xnode);
                   break;
               case "JpegBitmapDecoder":
                   OnJpegBitmapDecoderNode(xnode);
                   break;
               case "JpegBitmapEncoder":
                   OnJpegBitmapEncoderNode(xnode);
                   break;
               case "JumpItem":
                   OnJumpItemNode(xnode);
                   break;
               case "JumpPath":
                   OnJumpPathNode(xnode);
                   break;
               case "JumpTask":
                   OnJumpTaskNode(xnode);
                   break;
               case "KeyBinding":
                   OnKeyBindingNode(xnode);
                   break;
               case "KeyboardDevice":
                   OnKeyboardDeviceNode(xnode);
                   break;
               case "KeyboardEventArgs":
                   OnKeyboardEventArgsNode(xnode);
                   break;
               case "KeyboardFocusChangedEventArgs":
                   OnKeyboardFocusChangedEventArgsNode(xnode);
                   break;
               case "KeyboardInputPrOviderAcquireFocusEventArgs":
                   OnKeyboardInputPrOviderAcquireFocusEventArgsNode(xnode);
                   break;
               case "KeyEventArgs":
                   OnKeyEventArgsNode(xnode);
                   break;
               case "KevGesture":
                   OnKevGestureNode(xnode);
                   break;
               case "KevGestureValueSerializer":
                   OnKevGestureValueSerializerNode(xnode);
                   break;
               case "KeySpline":
                   OnKeySplineNode(xnode);
                   break;
               case "KeyTrigger":
                   OnKeyTriggerNode(xnode);
                   break;
               case "KeyValueSerializer":
                   OnKeyValueSerializerNode(xnode);
                   break;
               case "Label":
                   OnLabelNode(xnode);
                   break;
               case "LabelAutomationPeer":
                   OnLabelAutomationPeerNode(xnode);
                   break;
               case "LateBoundBitmapDecoder":
                   OnLateBoundBitmapDecoderNode(xnode);
                   break;
               case "LaunchUriOrFileAction":
                   OnLaunchUriOrFileActionNode(xnode);
                   break;
               case "Light":
                   OnLightNode(xnode);
                   break;
               case "Line":
                   OnLineNode(xnode);
                   break;
               case "LinearByteKeyFrame":
                   OnLinearByteKeyFrameNode(xnode);
                   break;
               case "LinearColorKeyFrame":
                   OnLinearColorKeyFrameNode(xnode);
                   break;
               case "LinearDecimalKeyFrame":
                   OnLinearDecimalKeyFrameNode(xnode);
                   break;
               case "LinearDoubleKeyFrame":
                   OnLinearDoubleKeyFrameNode(xnode);
                   break;
               case "LinearGradientBrush":
                   OnLinearGradientBrushNode(xnode);
                   break;
               case "LinearInt16KeyFrame":
                   OnLinearInt16KeyFrameNode(xnode);
                   break;
               case "LinearInt32KeyFrame":
                   OnLinearInt32KeyFrameNode(xnode);
                   break;
               case "LinearInt64KeyFrame":
                   OnLinearInt64KeyFrameNode(xnode);
                   break;
               case "LinearPoint3DKeyFrame":
                   OnLinearPoint3DKeyFrameNode(xnode);
                   break;
               case "LinearPointKeyFrame":
                   OnLinearPointKeyFrameNode(xnode);
                   break;
               case "LinearQuaternionKeyFrame":
                   OnLinearQuaternionKeyFrameNode(xnode);
                   break;
               case "LinearRectKeyFrame":
                   OnLinearRectKeyFrameNode(xnode);
                   break;
               case "LinearRotation3DKeyFrame":
                   OnLinearRotation3DKeyFrameNode(xnode);
                   break;
               case "LinearSingleKeyFrame":
                   OnLinearSingleKeyFrameNode(xnode);
                   break;
               case "LinearSizeKeyFrame":
                   OnLinearSizeKeyFrameNode(xnode);
                   break;
               case "LinearThicknessKeyFrame":
                   OnLinearThicknessKeyFrameNode(xnode);
                   break;
               case "LinearVector3DKeyFrame":
                   OnLinearVector3DKeyFrameNode(xnode);
                   break;
               case "LinearVectorKeyFrame":
                   OnLinearVectorKeyFrameNode(xnode);
                   break;
               case "LineBreak":
                   OnLineBreakNode(xnode);
                   break;
               case "LineGeometry":
                   OnLineGeometryNode(xnode);
                   break;
               case "LineSeement":
                   OnLineSeementNode(xnode);
                   break;
               case "List":
                   OnListNode(xnode);
                   break;
               case "ListBox":
                   OnListBoxNode(xnode);
                   break;
               case "ListBoxAutomationPeer":
                   OnListBoxAutomationPeerNode(xnode);
                   break;
               case "ListBoxltem":
                   OnListBoxltemNode(xnode);
                   break;
               case "ListBoxItemAutomationPeer":
                   OnListBoxItemAutomationPeerNode(xnode);
                   break;
               case "ListBoxItemWrapperAutomationPecer":
                   OnListBoxItemWrapperAutomationPecerNode(xnode);
                   break;
               case "ListColectionView":
                   OnListColectionViewNode(xnode);
                   break;
               case "ListItem":
                   OnListItemNode(xnode);
                   break;
               case "ListitemStructure":
                   OnListitemStructureNode(xnode);
                   break;
               case "ListStructure":
                   OnListStructureNode(xnode);
                   break;
               case "ListView":
                   OnListViewNode(xnode);
                   break;
               case "ListViewAutomationPeer":
                   OnListViewAutomationPeerNode(xnode);
                   break;
               case "ListViewItem":
                   OnListViewItemNode(xnode);
                   break;
               case "LostFocusEventManager":
                   OnLostFocusEventManagerNode(xnode);
                   break;
               case "ManipulationBoundaryFeedbackEvetArgs":
                   OnManipulationBoundaryFeedbackEvetArgsNode(xnode);
                   break;
               case "ManipulationCompletedEventArgs":
                   OnManipulationCompletedEventArgsNode(xnode);
                   break;
               case "ManipulationDeltaEventArgs":
                   OnManipulationDeltaEventArgsNode(xnode);
                   break;
               case "ManipulationInertiaStartingEventArgs":
                   OnManipulationInertiaStartingEventArgsNode(xnode);
                   break;
               case "ManipulationStartedEventArgs":
                   OnManipulationStartedEventArgsNode(xnode);
                   break;
               case "ManıpulationStartingErentArgs":
                   OnManıpulationStartingErentArgsNode(xnode);
                   break;
               case "MarkupExtension":
                   OnMarkupExtensionNode(xnode);
                   break;
               case "Material":
                   OnMaterialNode(xnode);
                   break;
               case "MaterialCollection":
                   OnMaterialCollectionNode(xnode);
                   break;
               case "MaterialGroup":
                   OnMaterialGroupNode(xnode);
                   break;
               case "Matrix3DValueSerializer":
                   OnMatrix3DValueSerializerNode(xnode);
                   break;
               case "MatrixAnimationBase":
                   OnMatrixAnimationBaseNode(xnode);
                   break;
               case "MatrixAnimationUsingKeyFrames":
                   OnMatrixAnimationUsingKeyFramesNode(xnode);
                   break;
               case "MatrixAnimationUsingPath":
                   OnMatrixAnimationUsingPathNode(xnode);
                   break;
               case "MatrixCamera":
                   OnMatrixCameraNode(xnode);
                   break;
               case "MatrixKeyFrame":
                   OnMatrixKeyFrameNode(xnode);
                   break;
               case "MatrixKeyFrameCollection":
                   OnMatrixKeyFrameCollectionNode(xnode);
                   break;
               case "MatrixTransform":
                   OnMatrixTransformNode(xnode);
                   break;
               case "MatrixTransform3D":
                   OnMatrixTransform3DNode(xnode);
                   break;
               case "MatrixValueSerializer":
                   OnMatrixValueSerializerNode(xnode);
                   break;
               case "MediaClock":
                   OnMediaClockNode(xnode);
                   break;
               case "MediaElement":
                   OnMediaElementNode(xnode);
                   break;
               case "MediaElementAutomationPeer":
                   OnMediaElementAutomationPeerNode(xnode);
                   break;
               case "MediaPlayer":
                   OnMediaPlayerNode(xnode);
                   break;
               case "MediaScriptCommandRoutedEventArgs":
                   OnMediaScriptCommandRoutedEventArgsNode(xnode);
                   break;
               case "MediaTimeline":
                   OnMediaTimelineNode(xnode);
                   break;
               case "MemberDefinition":
                   OnMemberDefinitionNode(xnode);
                   break;
               case "Menu":
                   OnMenuNode(xnode);
                   break;
               case "MenuAutomationPeer":
                   OnMenuAutomationPeerNode(xnode);
                   break;
               case "MenuBase":
                   OnMenuBaseNode(xnode);
                   break;
               case "MenuItem":
                   OnMenuItemNode(xnode);
                   break;
               case "MenuItemAutomationPeer":
                   OnMenuItemAutomationPeerNode(xnode);
                   break;
               case "MeshGeometry3D":
                   OnMeshGeometry3DNode(xnode);
                   break;
               case "Model3D":
                   OnModel3DNode(xnode);
                   break;
               case "Model3DCollection":
                   OnModel3DCollectionNode(xnode);
                   break;
               case "Model3DGroup":
                   OnModel3DGroupNode(xnode);
                   break;
               case "ModelUIElement3D":
                   OnModelUIElement3DNode(xnode);
                   break;
               case "ModelVisual3D":
                   OnModelVisual3DNode(xnode);
                   break;
               case "ModifierKeysValueSerializer":
                   OnModifierKeysValueSerializerNode(xnode);
                   break;
               case "MouseActionValueSerializer":
                   OnMouseActionValueSerializerNode(xnode);
                   break;
               case "MouseBinding":
                   OnMouseBindingNode(xnode);
                   break;
               case "MouseButtonEventArgs":
                   OnMouseButtonEventArgsNode(xnode);
                   break;
               case "MouseDevice":
                   OnMouseDeviceNode(xnode);
                   break;
               case "MouseDragElementBehavior":
                   OnMouseDragElementBehaviorNode(xnode);
                   break;
               case "MouseEventArgs":
                   OnMouseEventArgsNode(xnode);
                   break;
               case "MouseGesture":
                   OnMouseGestureNode(xnode);
                   break;
               case "MouseGestureValueSerializer":
                   OnMouseGestureValueSerializerNode(xnode);
                   break;
               case "MouseWheelEventArgs":
                   OnMouseWheelEventArgsNode(xnode);
                   break;
               case "MultiBinding":
                   OnMultiBindingNode(xnode);
                   break;
               case "MultiBindingExpression":
                   OnMultiBindingExpressionNode(xnode);
                   break;
               case "MultiDataTrigger":
                   OnMultiDataTriggerNode(xnode);
                   break;
               case "MultiSelector":
                   OnMultiSelectorNode(xnode);
                   break;
               case "MultiTrigger":
                   OnMultiTriggerNode(xnode);
                   break;
               case "NamedElement":
                   OnNamedElementNode(xnode);
                   break;
               case "NavigationWindow":
                   OnNavigationWindowNode(xnode);
                   break;
               case "NavigationWindowAutomationPeer":
                   OnNavigationWindowAutomationPeerNode(xnode);
                   break;
               case "NotifyDataErrorValidationRule":
                   OnNotifyDataErrorValidationRuleNode(xnode);
                   break;
               case "NotifyInputEventArgs":
                   OnNotifyInputEventArgsNode(xnode);
                   break;
               case "NullExtension":
                   OnNullExtensionNode(xnode);
                   break;
               case "ObjectAnimationBase":
                   OnObjectAnimationBaseNode(xnode);
                   break;
               case "ObjectAnimationUsingKeyFrames":
                   OnObjectAnimationUsingKeyFramesNode(xnode);
                   break;
               case "ObjectDataProvider":
                   OnObjectDataProviderNode(xnode);
                   break;
               case "ObjectKeyFrame":
                   OnObjectKeyFrameNode(xnode);
                   break;
               case "ObjectKeyFrameCollection":
                   OnObjectKeyFrameCollectionNode(xnode);
                   break;
               case "OpenFileDialog":
                   OnOpenFileDialogNode(xnode);
                   break;
               case "OrthographicCamera":
                   OnOrthographicCameraNode(xnode);
                   break;
               case "OuterGlowBitmapEffect":
                   OnOuterGlowBitmapEffectNode(xnode);
                   break;
               case "Package":
                   OnPackageNode(xnode);
                   break;
               case "PackagePart":
                   OnPackagePartNode(xnode);
                   break;
               case "Page":
                   OnPageNode(xnode);
                   break;
               case "PageContent":
                   OnPageContentNode(xnode);
                   break;
               case "PageFunction":
                   OnPageFunctionNode(xnode);
                   break;
               case "PageFunctionBase":
                   OnPageFunctionBaseNode(xnode);
                   break;
               case "Panel":
                   OnPanelNode(xnode);
                   break;
               case "Paragraph":
                   OnParagraphNode(xnode);
                   break;
               case "ParagraphStructure":
                   OnParagraphStructureNode(xnode);
                   break;
               case "ParallelTimeline":
                   OnParallelTimelineNode(xnode);
                   break;
               case "PasswordBox":
                   OnPasswordBoxNode(xnode);
                   break;
               case "PasswordBoxAutomationPeer":
                   OnPasswordBoxAutomationPeerNode(xnode);
                   break;
               case "Path":
                   OnPathNode(xnode);
                   break;
               case "PathFigure":
                   OnPathFigureNode(xnode);
                   break;
               case "PathFigureCollection":
                   OnPathFigureCollectionNode(xnode);
                   break;
               case "PathFigureCollectionValueSenalizer":
                   OnPathFigureCollectionValueSenalizerNode(xnode);
                   break;
               case "PathGeometry":
                   OnPathGeometryNode(xnode);
                   break;
               case "PathSegment":
                   OnPathSegmentNode(xnode);
                   break;
               case "PathSegmentCollection":
                   OnPathSegmentCollectionNode(xnode);
                   break;
               case "PauseStoryboard":
                   OnPauseStoryboardNode(xnode);
                   break;
               case "Pen":
                   OnPenNode(xnode);
                   break;
               case "PerspectiveCamera":
                   OnPerspectiveCameraNode(xnode);
                   break;
               case "PixelShader":
                   OnPixelShaderNode(xnode);
                   break;
               case "PlaySoundAction":
                   OnPlaySoundActionNode(xnode);
                   break;
               case "PngBitmapDecoder":
                   OnPngBitmapDecoderNode(xnode);
                   break;
               case "PngBitmapEncoder":
                   OnPngBitmapEncoderNode(xnode);
                   break;
               case "Point3DAnimation":
                   OnPoint3DAnimationNode(xnode);
                   break;
               case "Point3DAnimationBase":
                   OnPoint3DAnimationBaseNode(xnode);
                   break;
               case "Point3DAnimationUsingKeyFrames":
                   OnPoint3DAnimationUsingKeyFramesNode(xnode);
                   break;
               case "Point3DCollection":
                   OnPoint3DCollectionNode(xnode);
                   break;
               case "Point3DCollectionValueSerializer":
                   OnPoint3DCollectionValueSerializerNode(xnode);
                   break;
               case "Point3DKeyFrame":
                   OnPoint3DKeyFrameNode(xnode);
                   break;
               case "Point3DKeyFrameCollection":
                   OnPoint3DKeyFrameCollectionNode(xnode);
                   break;
               case "Point3DValueSerializer":
                   OnPoint3DValueSerializerNode(xnode);
                   break;
               case "Point4DValueSerializer":
                   OnPoint4DValueSerializerNode(xnode);
                   break;
               case "PointAnimation":
                   OnPointAnimationNode(xnode);
                   break;
               case "PointAnimationBase":
                   OnPointAnimationBaseNode(xnode);
                   break;
               case "PointAnimationUsingKeyFrames":
                   OnPointAnimationUsingKeyFramesNode(xnode);
                   break;
               case "PointAnimationUsingPath":
                   OnPointAnimationUsingPathNode(xnode);
                   break;
               case "PointCollection":
                   OnPointCollectionNode(xnode);
                   break;
               case "PointCollectionValueSerializer":
                   OnPointCollectionValueSerializerNode(xnode);
                   break;
               case "PointHitTestParameters":
                   OnPointHitTestParametersNode(xnode);
                   break;
               case "PointHitTestResult":
                   OnPointHitTestResultNode(xnode);
                   break;
               case "PointIListConverter":
                   OnPointIListConverterNode(xnode);
                   break;
               case "PointKeyFrame":
                   OnPointKeyFrameNode(xnode);
                   break;
               case "PointKeyFrameCollection":
                   OnPointKeyFrameCollectionNode(xnode);
                   break;
               case "PointLight":
                   OnPointLightNode(xnode);
                   break;
               case "PointLightBase":
                   OnPointLightBaseNode(xnode);
                   break;
               case "PointValueSerializer":
                   OnPointValueSerializerNode(xnode);
                   break;
               case "PolyBezierSegment":
                   OnPolyBezierSegmentNode(xnode);
                   break;
               case "Polygon":
                   OnPolygonNode(xnode);
                   break;
               case "Polylıne":
                   OnPolylıneNode(xnode);
                   break;
               case "PolyLineSegment":
                   OnPolyLineSegmentNode(xnode);
                   break;
               case "PolyQuadraticBezierSegment":
                   OnPolyQuadraticBezierSegmentNode(xnode);
                   break;
               case "Popup":
                   OnPopupNode(xnode);
                   break;
               case "PowerEase":
                   OnPowerEaseNode(xnode);
                   break;
               case "PreProcessInputEventArgs":
                   OnPreProcessInputEventArgsNode(xnode);
                   break;
               case "PresentationSource":
                   OnPresentationSourceNode(xnode);
                   break;
               case "PriorityBinding":
                   OnPriorityBindingNode(xnode);
                   break;
               case "PriorityBindingExpression":
                   OnPriorityBindingExpressionNode(xnode);
                   break;
               case "ProcessInputEventArgs":
                   OnProcessInputEventArgsNode(xnode);
                   break;
               case "ProgressBar":
                   OnProgressBarNode(xnode);
                   break;
               case "ProgressBarAutomattonPeer":
                   OnProgressBarAutomattonPeerNode(xnode);
                   break;
               case "ProjectionCamera":
                   OnProjectionCameraNode(xnode);
                   break;
               case "PropertyChangedEventManager":
                   OnPropertyChangedEventManagerNode(xnode);
                   break;
               case "PropertyChangedTrigger":
                   OnPropertyChangedTriggerNode(xnode);
                   break;
               case "PropertyDefinition":
                   OnPropertyDefinitionNode(xnode);
                   break;
               case "PropertyGroupDescription":
                   OnPropertyGroupDescriptionNode(xnode);
                   break;
               case "PropertyMetadata":
                   OnPropertyMetadataNode(xnode);
                   break;
               case "QuadraticBezierSegment":
                   OnQuadraticBezierSegmentNode(xnode);
                   break;
               case "OuadraticEase":
                   OnOuadraticEaseNode(xnode);
                   break;
               case "QuarticEase":
                   OnQuarticEaseNode(xnode);
                   break;
               case "QuaternionAnimation":
                   OnQuaternionAnimationNode(xnode);
                   break;
               case "QuaternionAnimationBase":
                   OnQuaternionAnimationBaseNode(xnode);
                   break;
               case "QuaternionAnimationUsingKeyFrames":
                   OnQuaternionAnimationUsingKeyFramesNode(xnode);
                   break;
               case "QuaternionKeyFrame":
                   OnQuaternionKeyFrameNode(xnode);
                   break;
               case "QuaternionKeyFrameCollection":
                   OnQuaternionKeyFrameCollectionNode(xnode);
                   break;
               case "QuaternionRotation3D":
                   OnQuaternionRotation3DNode(xnode);
                   break;
               case "QuaternionValueSerializer":
                   OnQuaternionValueSerializerNode(xnode);
                   break;
               case "QueryContinueDragEventArgs":
                   OnQueryContinueDragEventArgsNode(xnode);
                   break;
               case "QueryCursorEventArgs":
                   OnQueryCursorEventArgsNode(xnode);
                   break;
               case "QuinticEase":
                   OnQuinticEaseNode(xnode);
                   break;
               case "RadialGradientBrush":
                   OnRadialGradientBrushNode(xnode);
                   break;
               case "RadioButton":
                   OnRadioButtonNode(xnode);
                   break;
               case "RadioButtonAutomationPeer":
                   OnRadioButtonAutomationPeerNode(xnode);
                   break;
               case "RangeBase":
                   OnRangeBaseNode(xnode);
                   break;
               case "RangeBaseAutomationPeer":
                   OnRangeBaseAutomationPeerNode(xnode);
                   break;
               case "RayHitTestParameters":
                   OnRayHitTestParametersNode(xnode);
                   break;
               case "RayHitTestResult":
                   OnRayHitTestResultNode(xnode);
                   break;
               case "RayMeshGeometry3DHitTestResult":
                   OnRayMeshGeometry3DHitTestResultNode(xnode);
                   break;
               case "Rect3DValueSerializer":
                   OnRect3DValueSerializerNode(xnode);
                   break;
               case "Rectangle":
                   OnRectangleNode(xnode);
                   break;
               case "RectangleGeometry":
                   OnRectangleGeometryNode(xnode);
                   break;
               case "RectangleStylusShape":
                   OnRectangleStylusShapeNode(xnode);
                   break;
               case "RectAnimation":
                   OnRectAnimationNode(xnode);
                   break;
               case "RectAnimationBase":
                   OnRectAnimationBaseNode(xnode);
                   break;
               case "RectAnimationUsingKeyFrames":
                   OnRectAnimationUsingKeyFramesNode(xnode);
                   break;
               case "RectKeyFrame":
                   OnRectKeyFrameNode(xnode);
                   break;
               case "RectKeyFrameCollection":
                   OnRectKeyFrameCollectionNode(xnode);
                   break;
               case "RectValueSerializer":
                   OnRectValueSerializerNode(xnode);
                   break;
               case "Reference":
                   OnReferenceNode(xnode);
                   break;
               case "RelativeSource":
                   OnRelativeSourceNode(xnode);
                   break;
               case "RemoveElementAction":
                   OnRemoveElementActionNode(xnode);
                   break;
               case "RemoveStoryboard":
                   OnRemoveStoryboardNode(xnode);
                   break;
               case "RenderTargetBitmap":
                   OnRenderTargetBitmapNode(xnode);
                   break;
               case "RepeteButton":
                   OnRepeteButtonNode(xnode);
                   break;
               case "RepeatButtonAutomationPeer":
                   OnRepeatButtonAutomationPeerNode(xnode);
                   break;
               case "RequestBringIntoViewEventArgs":
                   OnRequestBringIntoViewEventArgsNode(xnode);
                   break;
               case "RequestNavigateEventArgs":
                   OnRequestNavigateEventArgsNode(xnode);
                   break;
               case "ResizeGrip":
                   OnResizeGripNode(xnode);
                   break;
               case "ResourceKey":
                   OnResourceKeyNode(xnode);
                   break;
               case "ResourceReferenceExpressionConverter":
                   OnResourceReferenceExpressionConverterNode(xnode);
                   break;
               case "ResumeStoryboard":
                   OnResumeStoryboardNode(xnode);
                   break;
               case "RichTextBox":
                   OnRichTextBoxNode(xnode);
                   break;
               case "RichTextBoxAutomationPeer":
                   OnRichTextBoxAutomationPeerNode(xnode);
                   break;
               case "RotateTransform":
                   OnRotateTransformNode(xnode);
                   break;
               case "RotateTransform3D":
                   OnRotateTransform3DNode(xnode);
                   break;
               case "Rotation3D":
                   OnRotation3DNode(xnode);
                   break;
               case "Rotation3DAnimation":
                   OnRotation3DAnimationNode(xnode);
                   break;
               case "Rotation3DAnimationBase":
                   OnRotation3DAnimationBaseNode(xnode);
                   break;
               case "Rotation3DAnimationUsingKeyFrames":
                   OnRotation3DAnimationUsingKeyFramesNode(xnode);
                   break;
               case "Rotation3DKeyFrame":
                   OnRotation3DKeyFrameNode(xnode);
                   break;
               case "Rotation3DKeyFrameCollection":
                   OnRotation3DKeyFrameCollectionNode(xnode);
                   break;
               case "RoutedCommand":
                   OnRoutedCommandNode(xnode);
                   break;
               case "RoutedEventArgs":
                   OnRoutedEventArgsNode(xnode);
                   break;
               case "RoutedPropertyChangedEventArgs":
                   OnRoutedPropertyChangedEventArgsNode(xnode);
                   break;
               case "RoutedUICommand":
                   OnRoutedUICommandNode(xnode);
                   break;
               case "RowDefinition":
                   OnRowDefinitionNode(xnode);
                   break;
               case "Run":
                   OnRunNode(xnode);
                   break;
               case "SaveFileDialog":
                   OnSaveFileDialogNode(xnode);
                   break;
               case "ScaleTransform":
                   OnScaleTransformNode(xnode);
                   break;
               case "ScaleTransform3D":
                   OnScaleTransform3DNode(xnode);
                   break;
               case "ScrollBar":
                   OnScrollBarNode(xnode);
                   break;
               case "ScrollBarAutomationPeer":
                   OnScrollBarAutomationPeerNode(xnode);
                   break;
               case "ScrollChangedEventArgs":
                   OnScrollChangedEventArgsNode(xnode);
                   break;
               case "ScrollContentPresenter":
                   OnScrollContentPresenterNode(xnode);
                   break;
               case "SerollEventArgs":
                   OnSerollEventArgsNode(xnode);
                   break;
               case "ScrollViewer":
                   OnScrollViewerNode(xnode);
                   break;
               case "ScrollViewerAutomationPeer":
                   OnScrollViewerAutomationPeerNode(xnode);
                   break;
               case "Section":
                   OnSectionNode(xnode);
                   break;
               case "SectionStructure":
                   OnSectionStructureNode(xnode);
                   break;
               case "SeekStoryboard":
                   OnSeekStoryboardNode(xnode);
                   break;
               case "SelectionChangedEventArgs":
                   OnSelectionChangedEventArgsNode(xnode);
                   break;
               case "SelectiveScrollingGrid":
                   OnSelectiveScrollingGridNode(xnode);
                   break;
               case "Selector":
                   OnSelectorNode(xnode);
                   break;
               case "SelectorAutomationPeer":
                   OnSelectorAutomationPeerNode(xnode);
                   break;
               case "SelectorItemAutomationPeer":
                   OnSelectorItemAutomationPeerNode(xnode);
                   break;
               case "SemanticBasicElement":
                   OnSemanticBasicElementNode(xnode);
                   break;
               case "Separator":
                   OnSeparatorNode(xnode);
                   break;
               case "SeparatorAutomationPeer":
                   OnSeparatorAutomationPeerNode(xnode);
                   break;
               case "ServiceProviders":
                   OnServiceProvidersNode(xnode);
                   break;
               case "SetDataStoreValueAction":
                   OnSetDataStoreValueActionNode(xnode);
                   break;
               case "SetStoryboardSpeedRatio":
                   OnSetStoryboardSpeedRatioNode(xnode);
                   break;
               case "Setter":
                   OnSetterNode(xnode);
                   break;
               case "SetterBase":
                   OnSetterBaseNode(xnode);
                   break;
               case "ShaderEfect":
                   OnShaderEfectNode(xnode);
                   break;
               case "Shape":
                   OnShapeNode(xnode);
                   break;
               case "SineEase":
                   OnSineEaseNode(xnode);
                   break;
               case "SingleAnimation":
                   OnSingleAnimationNode(xnode);
                   break;
               case "SingleAnimationBase":
                   OnSingleAnimationBaseNode(xnode);
                   break;
               case "SingleAnimationUsingKeyFrames":
                   OnSingleAnimationUsingKeyFramesNode(xnode);
                   break;
               case "SingleKeyFrame":
                   OnSingleKeyFrameNode(xnode);
                   break;
               case "SingleKeyFrameCollection":
                   OnSingleKeyFrameCollectionNode(xnode);
                   break;
               case "Size3DValueSerializer":
                   OnSize3DValueSerializerNode(xnode);
                   break;
               case "SizeAnimation":
                   OnSizeAnimationNode(xnode);
                   break;
               case "SizeAnimationBase":
                   OnSizeAnimationBaseNode(xnode);
                   break;
               case "SizeAnimationUsingKeyFrames":
                   OnSizeAnimationUsingKeyFramesNode(xnode);
                   break;
               case "SizeChangedEventArgs":
                   OnSizeChangedEventArgsNode(xnode);
                   break;
               case "SizeKeyFrame":
                   OnSizeKeyFrameNode(xnode);
                   break;
               case "SizeKeyFrameCollection":
                   OnSizeKeyFrameCollectionNode(xnode);
                   break;
               case "SizeValueSerializer":
                   OnSizeValueSerializerNode(xnode);
                   break;
               case "SkewTransform":
                   OnSkewTransformNode(xnode);
                   break;
               case "SkipStoryboardToFill":
                   OnSkipStoryboardToFillNode(xnode);
                   break;
               case "Slider":
                   OnSliderNode(xnode);
                   break;
               case "SiderAutomationPeer":
                   OnSiderAutomationPeerNode(xnode);
                   break;
               case "SolidColorBrush":
                   OnSolidColorBrushNode(xnode);
                   break;
               case "SoundPlayerAction":
                   OnSoundPlayerActionNode(xnode);
                   break;
               case "SourceChangedEventArgs":
                   OnSourceChangedEventArgsNode(xnode);
                   break;
               case "Span":
                   OnSpanNode(xnode);
                   break;
               case "SpecularMaterial":
                   OnSpecularMaterialNode(xnode);
                   break;
               case "SplineByteKeyFrame":
                   OnSplineByteKeyFrameNode(xnode);
                   break;
               case "SplıneColorKeyFrame":
                   OnSplıneColorKeyFrameNode(xnode);
                   break;
               case "SplineDecimalKeyFrame":
                   OnSplineDecimalKeyFrameNode(xnode);
                   break;
               case "SplineDoubleKeyFrame":
                   OnSplineDoubleKeyFrameNode(xnode);
                   break;
               case "Splinelnt16KeyFrame":
                   OnSplinelnt16KeyFrameNode(xnode);
                   break;
               case "Splinelnt32KeyFrame":
                   OnSplinelnt32KeyFrameNode(xnode);
                   break;
               case "Splinelnt64KeyFrame":
                   OnSplinelnt64KeyFrameNode(xnode);
                   break;
               case "SplinePoint3DKeyFrame":
                   OnSplinePoint3DKeyFrameNode(xnode);
                   break;
               case "SplinePointKevFrame":
                   OnSplinePointKevFrameNode(xnode);
                   break;
               case "SplineQuaternionKeyFrame":
                   OnSplineQuaternionKeyFrameNode(xnode);
                   break;
               case "SplineRectKeyFrame":
                   OnSplineRectKeyFrameNode(xnode);
                   break;
               case "SplineRotation3DKeyFrame":
                   OnSplineRotation3DKeyFrameNode(xnode);
                   break;
               case "SplineSingleKeyFrame":
                   OnSplineSingleKeyFrameNode(xnode);
                   break;
               case "SplineSizeKeyFrame":
                   OnSplineSizeKeyFrameNode(xnode);
                   break;
               case "SplineThicknessKeyFrame":
                   OnSplineThicknessKeyFrameNode(xnode);
                   break;
               case "SplineVector3DKeyFrame":
                   OnSplineVector3DKeyFrameNode(xnode);
                   break;
               case "SplineVectorKeyFrame":
                   OnSplineVectorKeyFrameNode(xnode);
                   break;
               case "SpotLight":
                   OnSpotLightNode(xnode);
                   break;
               case "StackPanel":
                   OnStackPanelNode(xnode);
                   break;
               case "StaticExtension":
                   OnStaticExtensionNode(xnode);
                   break;
               case "StaticResourceExtension":
                   OnStaticResourceExtensionNode(xnode);
                   break;
               case "StatusBar":
                   OnStatusBarNode(xnode);
                   break;
               case "StatusBarAutomationPeer":
                   OnStatusBarAutomationPeerNode(xnode);
                   break;
               case "StatusBarItem":
                   OnStatusBarItemNode(xnode);
                   break;
               case "StatusBarItemAutomationPeer":
                   OnStatusBarItemAutomationPeerNode(xnode);
                   break;
               case "StickyNoteControl":
                   OnStickyNoteControlNode(xnode);
                   break;
               case "StopStoryboard":
                   OnStopStoryboardNode(xnode);
                   break;
               case "Storyboard":
                   OnStoryboardNode(xnode);
                   break;
               case "StoryboardAction":
                   OnStoryboardActionNode(xnode);
                   break;
               case "StoryboardCompletedTrigger":
                   OnStoryboardCompletedTriggerNode(xnode);
                   break;
               case "StoryboardTrigger":
                   OnStoryboardTriggerNode(xnode);
                   break;
               case "StoryBreak":
                   OnStoryBreakNode(xnode);
                   break;
               case "StreamGeometry":
                   OnStreamGeometryNode(xnode);
                   break;
               case "StreamGeometryContext":
                   OnStreamGeometryContextNode(xnode);
                   break;
               case "StringAnimationBase":
                   OnStringAnimationBaseNode(xnode);
                   break;
               case "StringAnimationUsingKevFrames":
                   OnStringAnimationUsingKevFramesNode(xnode);
                   break;
               case "StringKeyFrame":
                   OnStringKeyFrameNode(xnode);
                   break;
               case "StringKeyFrameCollection":
                   OnStringKeyFrameCollectionNode(xnode);
                   break;
               case "Style":
                   OnStyleNode(xnode);
                   break;
               case "StylusButtonEventArgs":
                   OnStylusButtonEventArgsNode(xnode);
                   break;
               case "StylusDevice":
                   OnStylusDeviceNode(xnode);
                   break;
               case "StylusDownEventArgs":
                   OnStylusDownEventArgsNode(xnode);
                   break;
               case "StylusPlugIn":
                   OnStylusPlugInNode(xnode);
                   break;
               case "StylusEventArgs":
                   OnStylusEventArgsNode(xnode);
                   break;
               case "StylusPontProperty":
                   OnStylusPontPropertyNode(xnode);
                   break;
               case "StylusPointPropertyInfo":
                   OnStylusPointPropertyInfoNode(xnode);
                   break;
               case "StylusShape":
                   OnStylusShapeNode(xnode);
                   break;
               case "StylusSystemGestureEventArgs":
                   OnStylusSystemGestureEventArgsNode(xnode);
                   break;
               case "TabControl":
                   OnTabControlNode(xnode);
                   break;
               case "TabControlAutomationPeer":
                   OnTabControlAutomationPeerNode(xnode);
                   break;
               case "TabItern":
                   OnTabIternNode(xnode);
                   break;
               case "TabItenAutomationPeer":
                   OnTabItenAutomationPeerNode(xnode);
                   break;
               case "TabItemWrapperAutomationPeer":
                   OnTabItemWrapperAutomationPeerNode(xnode);
                   break;
               case "Table":
                   OnTableNode(xnode);
                   break;
               case "TableAutomationPeer":
                   OnTableAutomationPeerNode(xnode);
                   break;
               case "TableCell":
                   OnTableCellNode(xnode);
                   break;
               case "TableCellAutomationPeer":
                   OnTableCellAutomationPeerNode(xnode);
                   break;
               case "TableCellStructure":
                   OnTableCellStructureNode(xnode);
                   break;
               case "TableColumn":
                   OnTableColumnNode(xnode);
                   break;
               case "TableRow":
                   OnTableRowNode(xnode);
                   break;
               case "TableRowGroup":
                   OnTableRowGroupNode(xnode);
                   break;
               case "TableRowGroupStructure":
                   OnTableRowGroupStructureNode(xnode);
                   break;
               case "TableRowStructure":
                   OnTableRowStructureNode(xnode);
                   break;
               case "TableStructure":
                   OnTableStructureNode(xnode);
                   break;
               case "TabletDevice":
                   OnTabletDeviceNode(xnode);
                   break;
               case "TabPanel":
                   OnTabPanelNode(xnode);
                   break;
               case "TargetedTriggerAction":
                   OnTargetedTriggerActionNode(xnode);
                   break;
               case "TaskbarltemInfo":
                   OnTaskbarltemInfoNode(xnode);
                   break;
               case "TemplateBindingExpression":
                   OnTemplateBindingExpressionNode(xnode);
                   break;
               case "TemplateBindingExtension":
                   OnTemplateBindingExtensionNode(xnode);
                   break;
               case "TemplateContentLoader":
                   OnTemplateContentLoaderNode(xnode);
                   break;
               case "TemplateKey":
                   OnTemplateKeyNode(xnode);
                   break;
               case "TextAutomationPeer":
                   OnTextAutomationPeerNode(xnode);
                   break;
               case "TextBlock":
                   OnTextBlockNode(xnode);
                   break;
               case "TextBlockAutomationPeer":
                   OnTextBlockAutomationPeerNode(xnode);
                   break;
               case "TextBox":
                   OnTextBoxNode(xnode);
                   break;
               case "TextBoxAutomationPeer":
                   OnTextBoxAutomationPeerNode(xnode);
                   break;
               case "TextBoxBase":
                   OnTextBoxBaseNode(xnode);
                   break;
               case "TextChangedEventArgs":
                   OnTextChangedEventArgsNode(xnode);
                   break;
               case "TextCharacters":
                   OnTextCharactersNode(xnode);
                   break;
               case "TextCollapsingProperties":
                   OnTextCollapsingPropertiesNode(xnode);
                   break;
               case "TextComposıtion":
                   OnTextComposıtionNode(xnode);
                   break;
               case "TextCompositionEventArgs":
                   OnTextCompositionEventArgsNode(xnode);
                   break;
               case "TextCompositionManager":
                   OnTextCompositionManagerNode(xnode);
                   break;
               case "TextDecoration":
                   OnTextDecorationNode(xnode);
                   break;
               case "TextDecorationCollection":
                   OnTextDecorationCollectionNode(xnode);
                   break;
               case "TextEffect":
                   OnTextEffectNode(xnode);
                   break;
               case "TextEftectCollection":
                   OnTextEftectCollectionNode(xnode);
                   break;
               case "TextElement":
                   OnTextElementNode(xnode);
                   break;
               case "TextElementAutomationPeer":
                   OnTextElementAutomationPeerNode(xnode);
                   break;
               case "TextEmbeddedObject":
                   OnTextEmbeddedObjectNode(xnode);
                   break;
               case "TextEndOfLine":
                   OnTextEndOfLineNode(xnode);
                   break;
               case "TextEndOfParagraph":
                   OnTextEndOfParagraphNode(xnode);
                   break;
               case "TextEndOfSegment":
                   OnTextEndOfSegmentNode(xnode);
                   break;
               case "TextHidden":
                   OnTextHiddenNode(xnode);
                   break;
               case "TextMarkerProperties":
                   OnTextMarkerPropertiesNode(xnode);
                   break;
               case "TextModifier":
                   OnTextModifierNode(xnode);
                   break;
               case "TextPointer":
                   OnTextPointerNode(xnode);
                   break;
               case "TextRange":
                   OnTextRangeNode(xnode);
                   break;
               case "TextRun":
                   OnTextRunNode(xnode);
                   break;
               case "TextSearch":
                   OnTextSearchNode(xnode);
                   break;
               case "TextSelection":
                   OnTextSelectionNode(xnode);
                   break;
               case "TextSimpleMarkerProperties":
                   OnTextSimpleMarkerPropertiesNode(xnode);
                   break;
               case "TextTrailingCharacterEllipsis":
                   OnTextTrailingCharacterEllipsisNode(xnode);
                   break;
               case "TextTrailingWordEllipsis":
                   OnTextTrailingWordEllipsisNode(xnode);
                   break;
               case "ThemeDictionaryExtension":
                   OnThemeDictionaryExtensionNode(xnode);
                   break;
               case "ThicknessAnimation":
                   OnThicknessAnimationNode(xnode);
                   break;
               case "ThicknessAnimationBase":
                   OnThicknessAnimationBaseNode(xnode);
                   break;
               case "ThicknessAnimationUsingKeyFrames":
                   OnThicknessAnimationUsingKeyFramesNode(xnode);
                   break;
               case "ThicknessKeyFrame":
                   OnThicknessKeyFrameNode(xnode);
                   break;
               case "ThicknessKeyFrameCollection":
                   OnThicknessKeyFrameCollectionNode(xnode);
                   break;
               case "Thumb":
                   OnThumbNode(xnode);
                   break;
               case "ThumbAutomationPeer":
                   OnThumbAutomationPeerNode(xnode);
                   break;
               case "ThumbButonInfo":
                   OnThumbButonInfoNode(xnode);
                   break;
               case "ThumbButtonlnfoCollection":
                   OnThumbButtonlnfoCollectionNode(xnode);
                   break;
               case "TickBar":
                   OnTickBarNode(xnode);
                   break;
               case "TiffBitmap":
                   OnTiffBitmapNode(xnode);
                   break;
               case "TiffBitmapEncoder":
                   OnTiffBitmapEncoderNode(xnode);
                   break;
               case "TileBrush":
                   OnTileBrushNode(xnode);
                   break;
               case "Timeline":
                   OnTimelineNode(xnode);
                   break;
               case "TimelineCollection":
                   OnTimelineCollectionNode(xnode);
                   break;
               case "TimelıneGroup":
                   OnTimelıneGroupNode(xnode);
                   break;
               case "TimerTrigger":
                   OnTimerTriggerNode(xnode);
                   break;
               case "ToggleButton":
                   OnToggleButtonNode(xnode);
                   break;
               case "ToggleButtonAutomationPeer":
                   OnToggleButtonAutomationPeerNode(xnode);
                   break;
               case "ToolBar":
                   OnToolBarNode(xnode);
                   break;
               case "TooIBarAutomationPeer":
                   OnTooIBarAutomationPeerNode(xnode);
                   break;
               case "ToolBarOverflowPanel":
                   OnToolBarOverflowPanelNode(xnode);
                   break;
               case "ToolBarPanel":
                   OnToolBarPanelNode(xnode);
                   break;
               case "ToolBarTray":
                   OnToolBarTrayNode(xnode);
                   break;
               case "ToolTip":
                   OnToolTipNode(xnode);
                   break;
               case "ToolTipAutomationPeer":
                   OnToolTipAutomationPeerNode(xnode);
                   break;
               case "ToolTipEventArg3G":
                   OnToolTipEventArg3GNode(xnode);
                   break;
               case "TouchDevice":
                   OnTouchDeviceNode(xnode);
                   break;
               case "TouchDeviceArgs":
                   OnTouchDeviceArgsNode(xnode);
                   break;
               case "Track":
                   OnTrackNode(xnode);
                   break;
               case "Transform":
                   OnTransformNode(xnode);
                   break;
               case "Transform3D":
                   OnTransform3DNode(xnode);
                   break;
               case "Transformn3DCollection":
                   OnTransformn3DCollectionNode(xnode);
                   break;
               case "Transform3DGroup":
                   OnTransform3DGroupNode(xnode);
                   break;
               case "TransformCollection":
                   OnTransformCollectionNode(xnode);
                   break;
               case "TransformedBitmap":
                   OnTransformedBitmapNode(xnode);
                   break;
               case "TransformGroup":
                   OnTransformGroupNode(xnode);
                   break;
               case "TransformValueSerializer":
                   OnTransformValueSerializerNode(xnode);
                   break;
               case "TransitionEfect":
                   OnTransitionEfectNode(xnode);
                   break;
               case "TranslateTransform":
                   OnTranslateTransformNode(xnode);
                   break;
               case "TranslateTransfom3D":
                   OnTranslateTransfom3DNode(xnode);
                   break;
               case "TranslateZoomRotateBehavior":
                   OnTranslateZoomRotateBehaviorNode(xnode);
                   break;
               case "TreeView":
                   OnTreeViewNode(xnode);
                   break;
               case "TreeViewAutomationPeer":
                   OnTreeViewAutomationPeerNode(xnode);
                   break;
               case "TreeViewDataltemAutomationPeer":
                   OnTreeViewDataltemAutomationPeerNode(xnode);
                   break;
               case "TreeViewItem":
                   OnTreeViewItemNode(xnode);
                   break;
               case "TreeViewItemAutomationPeer":
                   OnTreeViewItemAutomationPeerNode(xnode);
                   break;
               case "Trigger":
                   OnTriggerNode(xnode);
                   break;
               case "TriggerAction":
                   OnTriggerActionNode(xnode);
                   break;
               case "TriggerActionCollection":
                   OnTriggerActionCollectionNode(xnode);
                   break;
               case "TriggerBase":
                   OnTriggerBaseNode(xnode);
                   break;
               case "TriggerCollection":
                   OnTriggerCollectionNode(xnode);
                   break;
               case "TypeConverter":
                   OnTypeConverterNode(xnode);
                   break;
               case "TypeExtension":
                   OnTypeExtensionNode(xnode);
                   break;
               case "UIElement":
                   OnUIElementNode(xnode);
                   break;
               case "UElement3D":
                   OnUElement3DNode(xnode);
                   break;
               case "UIElement3DAutomationPeer":
                   OnUIElement3DAutomationPeerNode(xnode);
                   break;
               case "UIElementAutomationPeer":
                   OnUIElementAutomationPeerNode(xnode);
                   break;
               case "UIPropertyMetadata":
                   OnUIPropertyMetadataNode(xnode);
                   break;
               case "Underline":
                   OnUnderlineNode(xnode);
                   break;
               case "UniformGrid":
                   OnUniformGridNode(xnode);
                   break;
               case "UserControl":
                   OnUserControlNode(xnode);
                   break;
               case "UserControlAutomationPeer":
                   OnUserControlAutomationPeerNode(xnode);
                   break;
               case "UShortlListConverter":
                   OnUShortlListConverterNode(xnode);
                   break;
               case "ValidationErrorEventArgs":
                   OnValidationErrorEventArgsNode(xnode);
                   break;
               case "ValidationRule":
                   OnValidationRuleNode(xnode);
                   break;
               case "ValueSerializer":
                   OnValueSerializerNode(xnode);
                   break;
               case "Vector3DAnimation":
                   OnVector3DAnimationNode(xnode);
                   break;
               case "Vector3DAnimationBase":
                   OnVector3DAnimationBaseNode(xnode);
                   break;
               case "Vector3DAnimationUsingKeyFrames":
                   OnVector3DAnimationUsingKeyFramesNode(xnode);
                   break;
               case "Vector3DCollection":
                   OnVector3DCollectionNode(xnode);
                   break;
               case "Vector3DCollectionValueSerializer":
                   OnVector3DCollectionValueSerializerNode(xnode);
                   break;
               case "Vector3DKeyFrame":
                   OnVector3DKeyFrameNode(xnode);
                   break;
               case "Vector3DKevFrameCollection":
                   OnVector3DKevFrameCollectionNode(xnode);
                   break;
               case "Vector3DValueSerializer":
                   OnVector3DValueSerializerNode(xnode);
                   break;
               case "VectorAnimation":
                   OnVectorAnimationNode(xnode);
                   break;
               case "VectorAnimationBase":
                   OnVectorAnimationBaseNode(xnode);
                   break;
               case "VectorAnimationUsingKeyFrames":
                   OnVectorAnimationUsingKeyFramesNode(xnode);
                   break;
               case "VectorCollection":
                   OnVectorCollectionNode(xnode);
                   break;
               case "VectorCollectionValueSerializer":
                   OnVectorCollectionValueSerializerNode(xnode);
                   break;
               case "VectorKeyFrame":
                   OnVectorKeyFrameNode(xnode);
                   break;
               case "VectorKeyFrameCollection":
                   OnVectorKeyFrameCollectionNode(xnode);
                   break;
               case "VectorValueSerializer":
                   OnVectorValueSerializerNode(xnode);
                   break;
               case "VideoDrawing":
                   OnVideoDrawingNode(xnode);
                   break;
               case "ViewBase":
                   OnViewBaseNode(xnode);
                   break;
               case "Viewbox":
                   OnViewboxNode(xnode);
                   break;
               case "Viewport2DVisual3D":
                   OnViewport2DVisual3DNode(xnode);
                   break;
               case "Viewport3D":
                   OnViewport3DNode(xnode);
                   break;
               case "Viewport3DAutomationPeer":
                   OnViewport3DAutomationPeerNode(xnode);
                   break;
               case "Viewport3DVisual":
                   OnViewport3DVisualNode(xnode);
                   break;
               case "VrtualizingPanel":
                   OnVrtualizingPanelNode(xnode);
                   break;
               case "VtualizingStackPanel":
                   OnVtualizingStackPanelNode(xnode);
                   break;
               case "Visual":
                   OnVisualNode(xnode);
                   break;
               case "Visual3D":
                   OnVisual3DNode(xnode);
                   break;
               case "VisualBrush":
                   OnVisualBrushNode(xnode);
                   break;
               case "VisualState":
                   OnVisualStateNode(xnode);
                   break;
               case "VisualStateGroup":
                   OnVisualStateGroupNode(xnode);
                   break;
               case "VisualStateManager":
                   OnVisualStateManagerNode(xnode);
                   break;
               case "VisualTarget":
                   OnVisualTargetNode(xnode);
                   break;
               case "VisualTransition":
                   OnVisualTransitionNode(xnode);
                   break;
               case "WeakEventManager":
                   OnWeakEventManagerNode(xnode);
                   break;
               case "WebBrowser":
                   OnWebBrowserNode(xnode);
                   break;
               case "Window":
                   OnWindowNode(xnode);
                   break;
               case "WindowAutomationPeer":
                   OnWindowAutomationPeerNode(xnode);
                   break;
               case "WindowChrome":
                   OnWindowChromeNode(xnode);
                   break;
               case "WmpBitmapDecoder":
                   OnWmpBitmapDecoderNode(xnode);
                   break;
               case "WmpBitmapEncoder":
                   OnWmpBitmapEncoderNode(xnode);
                   break;
               case "WrapPanel":
                   OnWrapPanelNode(xnode);
                   break;
               case "WriteableBitmap":
                   OnWriteableBitmapNode(xnode);
                   break;
               case "XamlBackgroundReader":
                   OnXamlBackgroundReaderNode(xnode);
                   break;
               case "XamlDeferringLoader":
                   OnXamlDeferringLoaderNode(xnode);
                   break;
               case "XamlDesignerSernalizationManager":
                   OnXamlDesignerSernalizationManagerNode(xnode);
                   break;
               case "XamlDirective":
                   OnXamlDirectiveNode(xnode);
                   break;
               case "XamlDuplicateMemberException":
                   OnXamlDuplicateMemberExceptionNode(xnode);
                   break;
               case "XamlException":
                   OnXamlExceptionNode(xnode);
                   break;
               case "XamlInternalException":
                   OnXamlInternalExceptionNode(xnode);
                   break;
               case "XamlMember":
                   OnXamlMemberNode(xnode);
                   break;
               case "XamlObjectReader":
                   OnXamlObjectReaderNode(xnode);
                   break;
               case "XamlObjectReaderException":
                   OnXamlObjectReaderExceptionNode(xnode);
                   break;
               case "XamlObjectReaderSettings":
                   OnXamlObjectReaderSettingsNode(xnode);
                   break;
               case "XamlObjectWriter":
                   OnXamlObjectWriterNode(xnode);
                   break;
               case "XamlObjectWriterException":
                   OnXamlObjectWriterExceptionNode(xnode);
                   break;
               case "XamlObjectWriterSettings":
                   OnXamlObjectWriterSettingsNode(xnode);
                   break;
               case "XamlParseException":
                   OnXamlParseExceptionNode(xnode);
                   break;
               case "XamlReader":
                   OnXamlReaderNode(xnode);
                   break;
               case "XamlReaderSettings":
                   OnXamlReaderSettingsNode(xnode);
                   break;
               case "XamlSchemaException":
                   OnXamlSchemaExceptionNode(xnode);
                   break;
               case "XamlSetMarkupExtensionEventArgs":
                   OnXamlSetMarkupExtensionEventArgsNode(xnode);
                   break;
               case "XamlSetypeConverterEventArgs":
                   OnXamlSetypeConverterEventArgsNode(xnode);
                   break;
               case "XamSetValueEentArgs":
                   OnXamSetValueEentArgsNode(xnode);
                   break;
               case "XamlWriter":
                   OnXamlWriterNode(xnode);
                   break;
               case "XamlWriterSettings":
                   OnXamlWriterSettingsNode(xnode);
                   break;
               case "XamlXmlReader":
                   OnXamlXmlReaderNode(xnode);
                   break;
               case "XamlXmlReaderSettings":
                   OnXamlXmlReaderSettingsNode(xnode);
                   break;
               case "XamlXmlWriter":
                   OnXamlXmlWriterNode(xnode);
                   break;
               case "XamlXmlWriterException":
                   OnXamlXmlWriterExceptionNode(xnode);
                   break;
               case "XamlXmlWriterSettings":
                   OnXamlXmlWriterSettingsNode(xnode);
                   break;
               case "XmlDataProvider":
                   OnXmlDataProviderNode(xnode);
                   break;
               case "XmlStreamStore":
                   OnXmlStreamStoreNode(xnode);
                   break;
               case "ZipPackage":
                   OnZipPackageNode(xnode);
                   break;
               case "ZipPackagePart":
                   OnZipPackagePartNode(xnode);
                   break;
               case "IdealSoftTextBox":
                   OnIdealSoftTextBoxNode(xnode);
                   break;
               //
               default:
                   OnDefaultNode(xnode);
                   break;
           }
       }
   }

   public virtual void OnAccessKeyPressedEventArgsNode(XXmlNode xnode) {}
   public virtual void OnAccessTextNode(XXmlNode xnode) {}
   public virtual void OnActiveXHostNode(XXmlNode xnode) {}
   public virtual void OnAdormedElementPlaceholderNode(XXmlNode xnode) {}
   public virtual void OnAdornerNode(XXmlNode xnode) {}
   public virtual void OnAdornerContainerNode(XXmlNode xnode) {}
   public virtual void OnAdornerDecoratorNode(XXmlNode xnode) {}
   public virtual void OnAdornerHitTestResutNode(XXmlNode xnode) {}
   public virtual void OnAdornerLayerNode(XXmlNode xnode) {}
   public virtual void OnAffineTransform3DNode(XXmlNode xnode) {}
   public virtual void OnAmbientLightNode(XXmlNode xnode) {}
   public virtual void OnAnchoredBlockNode(XXmlNode xnode) {}
   public virtual void OnAnimatableNode(XXmlNode xnode) {}
   public virtual void OnAnimationClockNode(XXmlNode xnode) {}
   public virtual void OnAnimationTimelineNode(XXmlNode xnode) {}
   public virtual void OnAnnotationDocumemtPagnatorNode(XXmlNode xnode) {}
   public virtual void OnAnnotationServiceNode(XXmlNode xnode) {}
   public virtual void OnAnnotationStoreNode(XXmlNode xnode) {}
   public virtual void OnApplicationNode(XXmlNode xnode) {}
   public virtual void OnArcSegmentNode(XXmlNode xnode) {}
   public virtual void OnArrayExtensionNode(XXmlNode xnode) {}
   public virtual void OnAttachableCollectionNode(XXmlNode xnode) {}
   public virtual void OnAttachedPropertyBrowsableAttibuteNode(XXmlNode xnode) {}
   public virtual void OnAttachedPropertyBrowsableForChildrenAttributeNode(XXmlNode xnode) {}
   public virtual void OnAttachedPropertyBrowsableForTypeAttributeNode(XXmlNode xnode) {}
   public virtual void OnAttachedPropertyBrowsableWhenAttributePresentAttributeNode(XXmlNode xnode) {}
   public virtual void OnAttributeNode(XXmlNode xnode) {}
   public virtual void OnAutomationPeerNode(XXmlNode xnode) {}
   public virtual void OnAxisAngleRotation3DNode(XXmlNode xnode) {}
   public virtual void OnBackEaseNode(XXmlNode xnode) {}
   public virtual void OnBaml2006ReaderNode(XXmlNode xnode) {}
   public virtual void OnBaseIListConverterNode(XXmlNode xnode) {}
   public virtual void OnBeginStoryboardNode(XXmlNode xnode) {}
   public virtual void OnBehaviorNode(XXmlNode xnode) {}
   public virtual void OnBehaviorCollectionNode(XXmlNode xnode) {}
   public virtual void OnBevelBitmapEffectNode(XXmlNode xnode) {}
   public virtual void OnBezierSegmentNode(XXmlNode xnode) {}
   public virtual void OnBindingNode(XXmlNode xnode) {}
   public virtual void OnBindingBaseNode(XXmlNode xnode) {}
   public virtual void OnBindingExpressionNode(XXmlNode xnode) {}
   public virtual void OnBindingExpressionBaseNode(XXmlNode xnode) {}
   public virtual void OnBindingGroupNode(XXmlNode xnode) {}
   public virtual void OnBindingListCollectionViewNode(XXmlNode xnode) {}
   public virtual void OnBitmapCacheNode(XXmlNode xnode) {}
   public virtual void OnBitmapCacheBrushNode(XXmlNode xnode) {}
   public virtual void OnBitmapDecoderNode(XXmlNode xnode) {}
   public virtual void OnBitmapEffectNode(XXmlNode xnode) {}
   public virtual void OnBitmapEffectCollectionNode(XXmlNode xnode) {}
   public virtual void OnBitmapEffectGroupNode(XXmlNode xnode) {}
   public virtual void OnBitmapEffectInputNode(XXmlNode xnode) {}
   public virtual void OnBitmapEncoderNode(XXmlNode xnode) {}
   public virtual void OnBitmapFrameNode(XXmlNode xnode) {}
   public virtual void OnBitmapImageNode(XXmlNode xnode) {}
   public virtual void OnBitmapMetadataNode(XXmlNode xnode) {}
   public virtual void OnBitmapPaletteNode(XXmlNode xnode) {}
   public virtual void OnBitmapSourceNode(XXmlNode xnode) {}
   public virtual void OnBlockNode(XXmlNode xnode) {}
   public virtual void OnBlockElementNode(XXmlNode xnode) {}
   public virtual void OnBlockUIContainerNode(XXmlNode xnode) {}
   public virtual void OnBlurBitmapEffectNode(XXmlNode xnode) {}
   public virtual void OnBlurEffectNode(XXmlNode xnode) {}
   public virtual void OnBmpBitmapDecoderNode(XXmlNode xnode) {}
   public virtual void OnBmpBitmapEncoderNode(XXmlNode xnode) {}
   public virtual void OnBoldNode(XXmlNode xnode) {}
   public virtual void OnBooleanAnimationBaseNode(XXmlNode xnode) {}
   public virtual void OnBooleanAnimationUsingKeyFramesNode(XXmlNode xnode) {}
   public virtual void OnBooleanKeyFrameNode(XXmlNode xnode) {}
   public virtual void OnBooleanKeyFrameCollectionNode(XXmlNode xnode) {}
   public virtual void OnBoolIListConverterNode(XXmlNode xnode) {}
   public virtual void OnBorderNode(XXmlNode xnode) {}
   public virtual void OnBounceEaseNode(XXmlNode xnode) {}
   public virtual void OnBrushNode(XXmlNode xnode) {}
   public virtual void OnBrushValueSerializerNode(XXmlNode xnode) {}
   public virtual void OnBulletDecoratorNode(XXmlNode xnode) {}
   public virtual void OnButtonNode(XXmlNode xnode) {}
   public virtual void OnButtonAutomationPeerNode(XXmlNode xnode) {}
   public virtual void OnButtonBaseNode(XXmlNode xnode) {}
   public virtual void OnButtonBaseAutomationPeerNode(XXmlNode xnode) {}
   public virtual void OnByteAnimationNode(XXmlNode xnode) {}
   public virtual void OnByteAnimationBaseNode(XXmlNode xnode) {}
   public virtual void OnByteAnimationUsingKeyFramesNode(XXmlNode xnode) {}
   public virtual void OnByteKeyFrameNode(XXmlNode xnode) {}
   public virtual void OnBytekeyFrameCollectionNode(XXmlNode xnode) {}
   public virtual void OnCachedBitmapNode(XXmlNode xnode) {}
   public virtual void OnCacheModeNode(XXmlNode xnode) {}
   public virtual void OnCacheModeValueSerializerNode(XXmlNode xnode) {}
   public virtual void OnCalendarNode(XXmlNode xnode) {}
   public virtual void OnCalendarAutomationPeerNode(XXmlNode xnode) {}
   public virtual void OnCalendarButtonNode(XXmlNode xnode) {}
   public virtual void OnCalendarButtonAutomationPeerNode(XXmlNode xnode) {}
   public virtual void OnCalendarDateChangedEventArgsNode(XXmlNode xnode) {}
   public virtual void OnCalendarDayButtonNode(XXmlNode xnode) {}
   public virtual void OnCalendarltemNode(XXmlNode xnode) {}
   public virtual void OnCalendarModeChangedEventArgsNode(XXmlNode xnode) {}
   public virtual void OnCallMethodActionNode(XXmlNode xnode) {}
   public virtual void OnCameraNode(XXmlNode xnode) {}
   public virtual void OnCanExecuteChangedEventManagerNode(XXmlNode xnode) {}
   public virtual void OnCanExecuteRoutedEventArgsNode(XXmlNode xnode) {}
   public virtual void OnCanvasNode(XXmlNode xnode) {}
   public virtual void OnChangePropertyActionNode(XXmlNode xnode) {}
   public virtual void OnCharAnimationBaseNode(XXmlNode xnode) {}
   public virtual void OnCharAnimationUsingKeyFrameNode(XXmlNode xnode) {}
   public virtual void OnCharIListConverterNode(XXmlNode xnode) {}
   public virtual void OnCharKeyFrameNode(XXmlNode xnode) {}
   public virtual void OnCharKeyFrameCollectionNode(XXmlNode xnode) {}
   public virtual void OnCheckBoxNode(XXmlNode xnode) {}
   public virtual void OnCheckBoxAutomationPeerNode(XXmlNode xnode) {}
   public virtual void OnCircleEaseNode(XXmlNode xnode) {}
   public virtual void OnCleanUpVirtualizedItemEventArgsNode(XXmlNode xnode) {}
   public virtual void OnClockNode(XXmlNode xnode) {}
   public virtual void OnClockControllerNode(XXmlNode xnode) {}
   public virtual void OnClockGroupNode(XXmlNode xnode) {}
   public virtual void OnCollectionChangedEventManagerNode(XXmlNode xnode) {}
   public virtual void OnCollectionContainerNode(XXmlNode xnode) {}
   public virtual void OnCollectionViewNode(XXmlNode xnode) {}
   public virtual void OnCollectionViewSourceNode(XXmlNode xnode) {}
   public virtual void OnColorAnimationNode(XXmlNode xnode) {}
   public virtual void OnColorAnimationBaseNode(XXmlNode xnode) {}
   public virtual void OnColorAnimationUsingKeyFramesNode(XXmlNode xnode) {}
   public virtual void OnColorConvertedBitmapNode(XXmlNode xnode) {}
   public virtual void OnColorConvertedBitmapExtensionNode(XXmlNode xnode) {}
   public virtual void OnColorKeyFrameNode(XXmlNode xnode) {}
   public virtual void OnColorKeyFrameCollectionNode(XXmlNode xnode) {}
   public virtual void OnColorDefinitionNode(XXmlNode xnode) {}
   public virtual void OnCombinedGeometryNode(XXmlNode xnode) {}
   public virtual void OnComboBoxNode(XXmlNode xnode) {}
   public virtual void OnComboBoxAutomationPeerNode(XXmlNode xnode) {}
   public virtual void OnComboBoxltemNode(XXmlNode xnode) {}
   public virtual void OnCommonDialogNode(XXmlNode xnode) {}
   public virtual void OnComparisonConditionNode(XXmlNode xnode) {}
   public virtual void OnComponentResourceKeyNode(XXmlNode xnode) {}
   public virtual void OnComponentResourceKeyConverterNode(XXmlNode xnode) {}
   public virtual void OnCompositionTargetNode(XXmlNode xnode) {}
   public virtual void OnConditionalExpressionNode(XXmlNode xnode) {}
   public virtual void OnConditionBehaviorNode(XXmlNode xnode) {}
   public virtual void OnConditionCollectionNode(XXmlNode xnode) {}
   public virtual void OnContainerUIElement3DNode(XXmlNode xnode) {}
   public virtual void OnContainerVisualNode(XXmlNode xnode) {}
   public virtual void OnContentControlNode(XXmlNode xnode) {}
   public virtual void OnContentElementNode(XXmlNode xnode) {}
   public virtual void OnContentElementAutomationPeerNode(XXmlNode xnode) {}
   public virtual void OnContentLocatorNode(XXmlNode xnode) {}
   public virtual void OnContentocatorBaseNode(XXmlNode xnode) {}
   public virtual void OnContentLocatorGroupNode(XXmlNode xnode) {}
   public virtual void OnContentPositionNode(XXmlNode xnode) {}
   public virtual void OnContentPresenterNode(XXmlNode xnode) {}
   public virtual void OnContentTextAutomationPeerNode(XXmlNode xnode) {}
   public virtual void OnContextMenuNode(XXmlNode xnode) {}
   public virtual void OnContextMenuAutomationPeerNode(XXmlNode xnode) {}
   public virtual void OnContextMenuEventArgsNode(XXmlNode xnode) {}
   public virtual void OnControlNode(XXmlNode xnode) {}
   public virtual void OnControllableStoryboardActionNode(XXmlNode xnode) {}
   public virtual void OnControlStoryboardActionNode(XXmlNode xnode) {}
   public virtual void OnControlTemplateNode(XXmlNode xnode) {}
   public virtual void OnCroppedBitmapNode(XXmlNode xnode) {}
   public virtual void OnCubicEaseNode(XXmlNode xnode) {}
   public virtual void OnCurrentChangedEventManagerNode(XXmlNode xnode) {}
   public virtual void OnCurrentChangingEventManagerNode(XXmlNode xnode) {}
   public virtual void OnD3DImageNode(XXmlNode xnode) {}
   public virtual void OnDashStyleNode(XXmlNode xnode) {}
   public virtual void OnDataChangedEventManagerNode(XXmlNode xnode) {}
   public virtual void OnDataErrorValidationRuleNode(XXmlNode xnode) {}
   public virtual void OnDataGridNode(XXmlNode xnode) {}
   public virtual void OnDataGridAutomationPeerNode(XXmlNode xnode) {}
   public virtual void OnDataGridBoundColumnNode(XXmlNode xnode) {}
   public virtual void OnDataGridCellNode(XXmlNode xnode) {}
   public virtual void OnDataGridCellAutomationPeerNode(XXmlNode xnode) {}
   public virtual void OnDataGridCellItemAutomationPeerNode(XXmlNode xnode) {}
   public virtual void OnDataGridCellsPanelNode(XXmlNode xnode) {}
   public virtual void OnDataGridCellsPresenterNode(XXmlNode xnode) {}
   public virtual void OnDataGridCheckBoxColumnNode(XXmlNode xnode) {}
   public virtual void OnDataGridColumnNode(XXmlNode xnode) {}
   public virtual void OnDataGridColumnEventArgsNode(XXmlNode xnode) {}
   public virtual void OnDataGridColumnHeaderNode(XXmlNode xnode) {}
   public virtual void OnDataGridColumnHeaderAutomationPeerNode(XXmlNode xnode) {}
   public virtual void OnDataGridColumnHeaderItemAutomationPeerNode(XXmlNode xnode) {}
   public virtual void OnDataGridColumnHeadersPresenterNode(XXmlNode xnode) {}
   public virtual void OnDataGridColumnHeadersPresenterAutomationPeerNode(XXmlNode xnode) {}
   public virtual void OnDataGridColumnReorderingEventArgsNode(XXmlNode xnode) {}
   public virtual void OnDataGridComboBoxColumnNode(XXmlNode xnode) {}
   public virtual void OnDataGridDetailsPresenterNode(XXmlNode xnode) {}
   public virtual void OnDataGridDetailsPresenterAutomationPeerNode(XXmlNode xnode) {}
   public virtual void OnDataGridHyperlinkColumnNode(XXmlNode xnode) {}
   public virtual void OnDataGridItemAutomationPeerNode(XXmlNode xnode) {}
   public virtual void OnDataGridRowNode(XXmlNode xnode) {}
   public virtual void OnDataGridRowAutomationPeerNode(XXmlNode xnode) {}
   public virtual void OnDataGridRowHeaderNode(XXmlNode xnode) {}
   public virtual void OnDataGridRowHeaderAutomationPeerNode(XXmlNode xnode) {}
   public virtual void OnDataGridRowsPresenterNode(XXmlNode xnode) {}
   public virtual void OnDataGridSortingEventArgsNode(XXmlNode xnode) {}
   public virtual void OnDataGridTemplateColumnNode(XXmlNode xnode) {}
   public virtual void OnDataGridTextColumnNode(XXmlNode xnode) {}
   public virtual void OnDataObjectCopyingEventArgsNode(XXmlNode xnode) {}
   public virtual void OnDataObjectEventArgsNode(XXmlNode xnode) {}
   public virtual void OnDataObjectPastingEventArgsNode(XXmlNode xnode) {}
   public virtual void OnDataObjectSettingDataEventArgsNode(XXmlNode xnode) {}
   public virtual void OnDataSourceProviderNode(XXmlNode xnode) {}
   public virtual void OnDataStateBehaviorNode(XXmlNode xnode) {}
   public virtual void OnDataStoreChangedTriggerNode(XXmlNode xnode) {}
   public virtual void OnDataTemplateNode(XXmlNode xnode) {}
   public virtual void OnDataTemplateKeyNode(XXmlNode xnode) {}
   public virtual void OnDataTransferEventArgsNode(XXmlNode xnode) {}
   public virtual void OnDataTriggerNode(XXmlNode xnode) {}
   public virtual void OnDatePickerNode(XXmlNode xnode) {}
   public virtual void OnDatePickerAutomationPeerNode(XXmlNode xnode) {}
   public virtual void OnDatePickerTextBoxNode(XXmlNode xnode) {}
   public virtual void OnDateTimeAutomationPeerNode(XXmlNode xnode) {}
   public virtual void OnDateTimeValueSerializerNode(XXmlNode xnode) {}
   public virtual void OnDecimalAnimationNode(XXmlNode xnode) {}
   public virtual void OnDecimalAnimationBaseNode(XXmlNode xnode) {}
   public virtual void OnDecimalAnimationUsingKeyFramesNode(XXmlNode xnode) {}
   public virtual void OnDecimalKeyFrameNode(XXmlNode xnode) {}
   public virtual void OnDecimalKeyFrameCollectionNode(XXmlNode xnode) {}
   public virtual void OnDecoratorNode(XXmlNode xnode) {}
   public virtual void OnDefinitionBaseNode(XXmlNode xnode) {}
   public virtual void OnDependencyObjectNode(XXmlNode xnode) {}
   public virtual void OnDiffuseMaterialNode(XXmlNode xnode) {}
   public virtual void OnDirectionalLightNode(XXmlNode xnode) {}
   public virtual void OnDiscreteBooleanKeyFrameNode(XXmlNode xnode) {}
   public virtual void OnDiscreteByteKeyFrameNode(XXmlNode xnode) {}
   public virtual void OnDiscreteCharKevFrameNode(XXmlNode xnode) {}
   public virtual void OnDiscreteColorKeyFrameNode(XXmlNode xnode) {}
   public virtual void OnDiscreteDecimalKeyFrameNode(XXmlNode xnode) {}
   public virtual void OnDiscreteDoubleKeyFrameNode(XXmlNode xnode) {}
   public virtual void OnDiscreteInt16KevFrameNode(XXmlNode xnode) {}
   public virtual void OnDiscreteInt32KeyFrameNode(XXmlNode xnode) {}
   public virtual void OnDiscretent64KeyFrameNode(XXmlNode xnode) {}
   public virtual void OnDiscretelMatrixKeyFrameNode(XXmlNode xnode) {}
   public virtual void OnDiscereteObjectKeyFrameNode(XXmlNode xnode) {}
   public virtual void OnDiscretePoint3DKeyFrameNode(XXmlNode xnode) {}
   public virtual void OnDiscretePointKeyFrameNode(XXmlNode xnode) {}
   public virtual void OnDiscreteQuaternionKeyFrameNode(XXmlNode xnode) {}
   public virtual void OnDiscreteRectKeyFrameNode(XXmlNode xnode) {}
   public virtual void OnDiscreteRotation3DKeyFramneNode(XXmlNode xnode) {}
   public virtual void OnDiscreteSingleKeyFrameNode(XXmlNode xnode) {}
   public virtual void OnDiscreteSizeKeyFrameNode(XXmlNode xnode) {}
   public virtual void OnDiscreteStringKeyFrameNode(XXmlNode xnode) {}
   public virtual void OnDiscreteThicknessKeyFrameNode(XXmlNode xnode) {}
   public virtual void OnDiscreteVector3DKeyFrameNode(XXmlNode xnode) {}
   public virtual void OnDiscreteVectorKeyFrameNode(XXmlNode xnode) {}
   public virtual void OnDispatcherEventArgsNode(XXmlNode xnode) {}
   public virtual void OnDispatcherFrameNode(XXmlNode xnode) {}
   public virtual void OnDispatcherObjectNode(XXmlNode xnode) {}
   public virtual void OnDispatcherOperationNode(XXmlNode xnode) {}
   public virtual void OnDispatcherUnhandledExceptionEventArgsNode(XXmlNode xnode) {}
   public virtual void OnDispatcherUnhandledExceptionFilterEventArgsNode(XXmlNode xnode) {}
   public virtual void OnDockPanelNode(XXmlNode xnode) {}
   public virtual void OnDocumentAutomationPeerNode(XXmlNode xnode) {}
   public virtual void OnDocumentViewerAutomationPeerNode(XXmlNode xnode) {}
   public virtual void OnDocumentPageViewNode(XXmlNode xnode) {}
   public virtual void OnDocumentPageViewAutomationPeerNode(XXmlNode xnode) {}
   public virtual void OnDocumentPaginatorNode(XXmlNode xnode) {}
   public virtual void OnDocumentReferenceNode(XXmlNode xnode) {}
   public virtual void OnDocumentViewerNode(XXmlNode xnode) {}
   public virtual void OnDocumentViewerBaseAutomationPeerNode(XXmlNode xnode) {}
   public virtual void OnDoCumentViewerBaseNode(XXmlNode xnode) {}
   public virtual void OnDoubleAnimationNode(XXmlNode xnode) {}
   public virtual void OnDoubleAnimationBaseNode(XXmlNode xnode) {}
   public virtual void OnDoubleAmimationUsingKevFramesNode(XXmlNode xnode) {}
   public virtual void OnDoubleAnimationsingPathNode(XXmlNode xnode) {}
   public virtual void OnDoubleCollectionNode(XXmlNode xnode) {}
   public virtual void OnDoubleCollectionValueSenalizerNode(XXmlNode xnode) {}
   public virtual void OnDoubleIListConverterNode(XXmlNode xnode) {}
   public virtual void OnDoubleKeyFrameNode(XXmlNode xnode) {}
   public virtual void OnDoubleKeyFrameCollectionNode(XXmlNode xnode) {}
   public virtual void OnDragCompletedEventArgsNode(XXmlNode xnode) {}
   public virtual void OnDragDeltaEventArgsNode(XXmlNode xnode) {}
   public virtual void OnDragEventArgsNode(XXmlNode xnode) {}
   public virtual void OnDragStartedEventArgsNode(XXmlNode xnode) {}
   public virtual void OnDrawingNode(XXmlNode xnode) {}
   public virtual void OnDrawingBrushNode(XXmlNode xnode) {}
   public virtual void OnDrawingCollectionNode(XXmlNode xnode) {}
   public virtual void OnDrawingContextNode(XXmlNode xnode) {}
   public virtual void OnDrawingGroupNode(XXmlNode xnode) {}
   public virtual void OnDrawingImageNode(XXmlNode xnode) {}
   public virtual void OnDrawingVisualNode(XXmlNode xnode) {}
   public virtual void OnDropShadowBitmapEffectNode(XXmlNode xnode) {}
   public virtual void OnDropShadowEffectNode(XXmlNode xnode) {}
   public virtual void OnDynamicDocumentPaginatorNode(XXmlNode xnode) {}
   public virtual void OnDynamicRendererNode(XXmlNode xnode) {}
   public virtual void OnDynamicResourceExtensionNode(XXmlNode xnode) {}
   public virtual void OnEasingByteKeyFrameNode(XXmlNode xnode) {}
   public virtual void OnEasingColorKeyFrameNode(XXmlNode xnode) {}
   public virtual void OnEasingDecimalKeyFrameNode(XXmlNode xnode) {}
   public virtual void OnEasingDoubleKeyFrameNode(XXmlNode xnode) {}
   public virtual void OnEasingFunctionBaseNode(XXmlNode xnode) {}
   public virtual void OnEasingInt16KeyFrameNode(XXmlNode xnode) {}
   public virtual void OnEasingInt32KeyFrameNode(XXmlNode xnode) {}
   public virtual void OnEasinglnt64KeyFrameNode(XXmlNode xnode) {}
   public virtual void OnEasingPoint3DKeyFrameNode(XXmlNode xnode) {}
   public virtual void OnEasingPointKeyFrameNode(XXmlNode xnode) {}
   public virtual void OnEasingQuaternionKeyFrameNode(XXmlNode xnode) {}
   public virtual void OnEasingRectKeyFrameNode(XXmlNode xnode) {}
   public virtual void OnEasingRotation3DKeyFrameNode(XXmlNode xnode) {}
   public virtual void OnEasingSingleKeyFrameNode(XXmlNode xnode) {}
   public virtual void OnEasingSizeKeyFranmeNode(XXmlNode xnode) {}
   public virtual void OnEasingThicknessKeyFrameNode(XXmlNode xnode) {}
   public virtual void OnEasıngVector3DKeyFrameNode(XXmlNode xnode) {}
   public virtual void OnEasingVectorKeyFrameNode(XXmlNode xnode) {}
   public virtual void OnEffectNode(XXmlNode xnode) {}
   public virtual void OnElasticEaseNode(XXmlNode xnode) {}
   public virtual void OnEllipseNode(XXmlNode xnode) {}
   public virtual void OnEllipseGeometryNode(XXmlNode xnode) {}
   public virtual void OnEllipseStylusShapeNode(XXmlNode xnode) {}
   public virtual void OnEmbossBitmapEffectNode(XXmlNode xnode) {}
   public virtual void OnEmissiveMaterialNode(XXmlNode xnode) {}
   public virtual void OnErrorsChangedEventManagerNode(XXmlNode xnode) {}
   public virtual void OnEventArgsNode(XXmlNode xnode) {}
   public virtual void OnEventSetterNode(XXmlNode xnode) {}
   public virtual void OnEventTriggerNode(XXmlNode xnode) {}
   public virtual void OnEventTriggerBaseNode(XXmlNode xnode) {}
   public virtual void OnExceptionNode(XXmlNode xnode) {}
   public virtual void OnExceptionRoutedEventArgsNode(XXmlNode xnode) {}
   public virtual void OnExceptionValidationRuleNode(XXmlNode xnode) {}
   public virtual void OnExecutedRoutedEventArgsNode(XXmlNode xnode) {}
   public virtual void OnExpanderNode(XXmlNode xnode) {}
   public virtual void OnExpanderAutomationPeerNode(XXmlNode xnode) {}
   public virtual void OnExponentialEaseNode(XXmlNode xnode) {}
   public virtual void OnExpressionNode(XXmlNode xnode) {}
   public virtual void OnExpressionConverterNode(XXmlNode xnode) {}
   public virtual void OnExtendedVisualStateManagerNode(XXmlNode xnode) {}
   public virtual void OnFigureNode(XXmlNode xnode) {}
   public virtual void OnFigureStructureNode(XXmlNode xnode) {}
   public virtual void OnFileDialogNode(XXmlNode xnode) {}
   public virtual void OnFixedDocumentNode(XXmlNode xnode) {}
   public virtual void OnFixedDocumentSequenceNode(XXmlNode xnode) {}
   public virtual void OnFixedPageNode(XXmlNode xnode) {}
   public virtual void OnFixedPageAutomationPeerNode(XXmlNode xnode) {}
   public virtual void OnFloaterNode(XXmlNode xnode) {}
   public virtual void OnFlowDocumentNode(XXmlNode xnode) {}
   public virtual void OnFlowDocumentPageViewerNode(XXmlNode xnode) {}
   public virtual void OnFlowDocumentPageViewerAutomationPeerNode(XXmlNode xnode) {}
   public virtual void OnFlowDocumentReaderNode(XXmlNode xnode) {}
   public virtual void OnFlowDocumentReaderAutomationPeerNode(XXmlNode xnode) {}
   public virtual void OnFlowDocumentScrollViewerNode(XXmlNode xnode) {}
   public virtual void OnFlowDocumentScrollViewerAutomationPeerNode(XXmlNode xnode) {}
   public virtual void OnFluidMoveBehaviorNode(XXmlNode xnode) {}
   public virtual void OnFluidMoveBehaviorBaseNode(XXmlNode xnode) {}
   public virtual void OnFluidMoveSetTagBehaviorNode(XXmlNode xnode) {}
   public virtual void OnFontFamilyValueSerializerNode(XXmlNode xnode) {}
   public virtual void OnFormatConvertedBitmapNode(XXmlNode xnode) {}
   public virtual void OnFrameNode(XXmlNode xnode) {}
   public virtual void OnFrameAutomationPeerNode(XXmlNode xnode) {}
   public virtual void OnFrameworkContentElementNode(XXmlNode xnode) {}
   public virtual void OnFrameworkContentElementAutomationPeerNode(XXmlNode xnode) {}
   public virtual void OnFrameworkElementNode(XXmlNode xnode) {}
   public virtual void OnFrameworkElementAutomationPeerNode(XXmlNode xnode) {}
   public virtual void OnFrameworkPropertyMetadataNode(XXmlNode xnode) {}
   public virtual void OnFrameworkRichTextCompositionNode(XXmlNode xnode) {}
   public virtual void OnFrameworkTemplateNode(XXmlNode xnode) {}
   public virtual void OnFrameworkTextCompositionNode(XXmlNode xnode) {}
   public virtual void OnFreezableNode(XXmlNode xnode) {}
   public virtual void OnFreezableCollectionNode(XXmlNode xnode) {}
   public virtual void OnGeneralTransformNode(XXmlNode xnode) {}
   public virtual void OnGeneralTransform2DTo3DNode(XXmlNode xnode) {}
   public virtual void OnGeneralTransform3DNode(XXmlNode xnode) {}
   public virtual void OnGeneralTransform3DCollectionNode(XXmlNode xnode) {}
   public virtual void OnGeneralTransform3DGroupNode(XXmlNode xnode) {}
   public virtual void OnGeneralTransform3DTo2DNode(XXmlNode xnode) {}
   public virtual void OnGeneralTransformCollectionNode(XXmlNode xnode) {}
   public virtual void OnGeneralTransformGroupNode(XXmlNode xnode) {}
   public virtual void OnGenericRootAutomationPeerNode(XXmlNode xnode) {}
   public virtual void OnGeometryNode(XXmlNode xnode) {}
   public virtual void OnGeometry3DNode(XXmlNode xnode) {}
   public virtual void OnGeometryCollectionNode(XXmlNode xnode) {}
   public virtual void OnGeometryDrawingNode(XXmlNode xnode) {}
   public virtual void OnGeometryGroupNode(XXmlNode xnode) {}
   public virtual void OnGeometryHitTestParametersNode(XXmlNode xnode) {}
   public virtual void OnGeometryHitTestResultNode(XXmlNode xnode) {}
   public virtual void OnGeometryModel3DNode(XXmlNode xnode) {}
   public virtual void OnGeometryValueSenalizerNode(XXmlNode xnode) {}
   public virtual void OnGestureRecognizerNode(XXmlNode xnode) {}
   public virtual void OnGifBitmapDecoderNode(XXmlNode xnode) {}
   public virtual void OnGifBitmapEncoderNode(XXmlNode xnode) {}
   public virtual void OnGiveFeedbackEventArgsNode(XXmlNode xnode) {}
   public virtual void OnGlyphRunDrawingNode(XXmlNode xnode) {}
   public virtual void OnGlyphsNode(XXmlNode xnode) {}
   public virtual void OnGoToStateActionNode(XXmlNode xnode) {}
   public virtual void OnGradientBrushNode(XXmlNode xnode) {}
   public virtual void OnGradientStopNode(XXmlNode xnode) {}
   public virtual void OnGradientStopCollectionNode(XXmlNode xnode) {}
   public virtual void OnGridNode(XXmlNode xnode) {}
   public virtual void OnGridSplitterNode(XXmlNode xnode) {}
   public virtual void OnGridSplitterAutomationPeerNode(XXmlNode xnode) {}
   public virtual void OnGridViewNode(XXmlNode xnode) {}
   public virtual void OnGridViewCellAutomationPeerNode(XXmlNode xnode) {}
   public virtual void OnGridViewColumnNode(XXmlNode xnode) {}
   public virtual void OnGridViewColumnHeaderNode(XXmlNode xnode) {}
   public virtual void OnGidViewColumnHeaderAutomationPeerNode(XXmlNode xnode) {}
   public virtual void OnGridViewHeaderRowPresenterNode(XXmlNode xnode) {}
   public virtual void OnGridViewHeaderRowPresenterAutomationPeerNode(XXmlNode xnode) {}
   public virtual void OnGridViewItemAutomationPeerNode(XXmlNode xnode) {}
   public virtual void OnGridViewRowPresenterNode(XXmlNode xnode) {}
   public virtual void OnGridViewRowPresenterBaseNode(XXmlNode xnode) {}
   public virtual void OnGroupBoxNode(XXmlNode xnode) {}
   public virtual void OnGroupBoXAutomationPeerNode(XXmlNode xnode) {}
   public virtual void OnGroupDescriptionNode(XXmlNode xnode) {}
   public virtual void OnGroupltemNode(XXmlNode xnode) {}
   public virtual void OnGroupItemAutomationPeerNode(XXmlNode xnode) {}
   public virtual void OnGuidelineSetNode(XXmlNode xnode) {}
   public virtual void OnHeaderedContentControlNode(XXmlNode xnode) {}
   public virtual void OnHeaderedItemsControlNode(XXmlNode xnode) {}
   public virtual void OnHierarchicalDataTemplateNode(XXmlNode xnode) {}
   public virtual void OnHitTestParametersNode(XXmlNode xnode) {}
   public virtual void OnHitTestParameters3DNode(XXmlNode xnode) {}
   public virtual void OnHitTestResultNode(XXmlNode xnode) {}
   public virtual void OnHostVisualNode(XXmlNode xnode) {}
   public virtual void OnHwndHostNode(XXmlNode xnode) {}
   public virtual void OnHwndSourceNode(XXmlNode xnode) {}
   public virtual void OnHwndTargetNode(XXmlNode xnode) {}
   public virtual void OnHperlınkNode(XXmlNode xnode) {}
   public virtual void OnHyperlinkAutomationPeerNode(XXmlNode xnode) {}
   public virtual void OnIconBitmapDecoderNode(XXmlNode xnode) {}
   public virtual void OnImageNode(XXmlNode xnode) {}
   public virtual void OnImageAutomationPeerNode(XXmlNode xnode) {}
   public virtual void OnTmageBrushNode(XXmlNode xnode) {}
   public virtual void OnImageDrawingNode(XXmlNode xnode) {}
   public virtual void OnImageetadataNode(XXmlNode xnode) {}
   public virtual void OnImageSourceNode(XXmlNode xnode) {}
   public virtual void OnImageSourcealueSerializerNode(XXmlNode xnode) {}
   public virtual void OnIncrementalHitTesterNode(XXmlNode xnode) {}
   public virtual void OnIncrementalLassoHitTesterNode(XXmlNode xnode) {}
   public virtual void OnIncrementalStrokehHitTesterNode(XXmlNode xnode) {}
   public virtual void OnInkCanvasNode(XXmlNode xnode) {}
   public virtual void OnInkCanvasAutomationPeerNode(XXmlNode xnode) {}
   public virtual void OnInkCanvasGestureEventArgsNode(XXmlNode xnode) {}
   public virtual void OnInkCanvasStrokeCollectedEventArgsNode(XXmlNode xnode) {}
   public virtual void OnInkPresenterNode(XXmlNode xnode) {}
   public virtual void OnInkPresenterAutomationPeerNode(XXmlNode xnode) {}
   public virtual void OnInlineNode(XXmlNode xnode) {}
   public virtual void OnInlineUIContainerNode(XXmlNode xnode) {}
   public virtual void OnInPlaceBitmapMetadataNode(XXmlNode xnode) {}
   public virtual void OnInputBindıngNode(XXmlNode xnode) {}
   public virtual void OnInputDeviceNode(XXmlNode xnode) {}
   public virtual void OnInputEventArgsNode(XXmlNode xnode) {}
   public virtual void OnInputGestureNode(XXmlNode xnode) {}
   public virtual void OnInputanguageChangedEventArgsNode(XXmlNode xnode) {}
   public virtual void OnInputLanguageChangingEventArgsNode(XXmlNode xnode) {}
   public virtual void OnInputanguageEventArgsNode(XXmlNode xnode) {}
   public virtual void OnInputLanguageManagerNode(XXmlNode xnode) {}
   public virtual void OnInputManagerNode(XXmlNode xnode) {}
   public virtual void OnInputMethodNode(XXmlNode xnode) {}
   public virtual void OnInt16AnimationNode(XXmlNode xnode) {}
   public virtual void OnInt16AnimationBaseNode(XXmlNode xnode) {}
   public virtual void OnInt16AnimationBaseUsingKeyFramesNode(XXmlNode xnode) {}
   public virtual void OnInt16KeyFrameNode(XXmlNode xnode) {}
   public virtual void OnInt16KeyFrameCollectionNode(XXmlNode xnode) {}
   public virtual void OnInt32AnimationNode(XXmlNode xnode) {}
   public virtual void OnInt32AnimationBaseNode(XXmlNode xnode) {}
   public virtual void OnInt32AnimationUsingKeyFramesNode(XXmlNode xnode) {}
   public virtual void OnInt32CollectionNode(XXmlNode xnode) {}
   public virtual void OnInt32CollecionValueSerializerNode(XXmlNode xnode) {}
   public virtual void OnInt32KeyFrameNode(XXmlNode xnode) {}
   public virtual void OnInt32KeyFrameCollectionNode(XXmlNode xnode) {}
   public virtual void OnInt32RectValueSernalizerNode(XXmlNode xnode) {}
   public virtual void OnInt64AnimationNode(XXmlNode xnode) {}
   public virtual void OnInt64AnimationBaseNode(XXmlNode xnode) {}
   public virtual void OnInt64AnimationUsingKeyFramesNode(XXmlNode xnode) {}
   public virtual void OnInt64KevFrameNode(XXmlNode xnode) {}
   public virtual void OnInt64KevFrameCollectionNode(XXmlNode xnode) {}
   public virtual void OnInteropBitmapNode(XXmlNode xnode) {}
   public virtual void OnInvokeCommandActionNode(XXmlNode xnode) {}
   public virtual void OnItalicNode(XXmlNode xnode) {}
   public virtual void OnItemAutomationPeerNode(XXmlNode xnode) {}
   public virtual void OnItemCollectionNode(XXmlNode xnode) {}
   public virtual void OnItemContainerTernplateNode(XXmlNode xnode) {}
   public virtual void OnItemContainerTemplateKeyNode(XXmlNode xnode) {}
   public virtual void OnItemsControlNode(XXmlNode xnode) {}
   public virtual void OnItemsControlAutomationPeerNode(XXmlNode xnode) {}
   public virtual void OnItemsPanelTernplateNode(XXmlNode xnode) {}
   public virtual void OnItemsPresenterNode(XXmlNode xnode) {}
   public virtual void OnJournalEntryNode(XXmlNode xnode) {}
   public virtual void OnJpegBitmapDecoderNode(XXmlNode xnode) {}
   public virtual void OnJpegBitmapEncoderNode(XXmlNode xnode) {}
   public virtual void OnJumpItemNode(XXmlNode xnode) {}
   public virtual void OnJumpPathNode(XXmlNode xnode) {}
   public virtual void OnJumpTaskNode(XXmlNode xnode) {}
   public virtual void OnKeyBindingNode(XXmlNode xnode) {}
   public virtual void OnKeyboardDeviceNode(XXmlNode xnode) {}
   public virtual void OnKeyboardEventArgsNode(XXmlNode xnode) {}
   public virtual void OnKeyboardFocusChangedEventArgsNode(XXmlNode xnode) {}
   public virtual void OnKeyboardInputPrOviderAcquireFocusEventArgsNode(XXmlNode xnode) {}
   public virtual void OnKeyEventArgsNode(XXmlNode xnode) {}
   public virtual void OnKevGestureNode(XXmlNode xnode) {}
   public virtual void OnKevGestureValueSerializerNode(XXmlNode xnode) {}
   public virtual void OnKeySplineNode(XXmlNode xnode) {}
   public virtual void OnKeyTriggerNode(XXmlNode xnode) {}
   public virtual void OnKeyValueSerializerNode(XXmlNode xnode) {}
   public virtual void OnLabelNode(XXmlNode xnode) {}
   public virtual void OnLabelAutomationPeerNode(XXmlNode xnode) {}
   public virtual void OnLateBoundBitmapDecoderNode(XXmlNode xnode) {}
   public virtual void OnLaunchUriOrFileActionNode(XXmlNode xnode) {}
   public virtual void OnLightNode(XXmlNode xnode) {}
   public virtual void OnLineNode(XXmlNode xnode) {}
   public virtual void OnLinearByteKeyFrameNode(XXmlNode xnode) {}
   public virtual void OnLinearColorKeyFrameNode(XXmlNode xnode) {}
   public virtual void OnLinearDecimalKeyFrameNode(XXmlNode xnode) {}
   public virtual void OnLinearDoubleKeyFrameNode(XXmlNode xnode) {}
   public virtual void OnLinearGradientBrushNode(XXmlNode xnode) {}
   public virtual void OnLinearInt16KeyFrameNode(XXmlNode xnode) {}
   public virtual void OnLinearInt32KeyFrameNode(XXmlNode xnode) {}
   public virtual void OnLinearInt64KeyFrameNode(XXmlNode xnode) {}
   public virtual void OnLinearPoint3DKeyFrameNode(XXmlNode xnode) {}
   public virtual void OnLinearPointKeyFrameNode(XXmlNode xnode) {}
   public virtual void OnLinearQuaternionKeyFrameNode(XXmlNode xnode) {}
   public virtual void OnLinearRectKeyFrameNode(XXmlNode xnode) {}
   public virtual void OnLinearRotation3DKeyFrameNode(XXmlNode xnode) {}
   public virtual void OnLinearSingleKeyFrameNode(XXmlNode xnode) {}
   public virtual void OnLinearSizeKeyFrameNode(XXmlNode xnode) {}
   public virtual void OnLinearThicknessKeyFrameNode(XXmlNode xnode) {}
   public virtual void OnLinearVector3DKeyFrameNode(XXmlNode xnode) {}
   public virtual void OnLinearVectorKeyFrameNode(XXmlNode xnode) {}
   public virtual void OnLineBreakNode(XXmlNode xnode) {}
   public virtual void OnLineGeometryNode(XXmlNode xnode) {}
   public virtual void OnLineSeementNode(XXmlNode xnode) {}
   public virtual void OnListNode(XXmlNode xnode) {}
   public virtual void OnListBoxNode(XXmlNode xnode) {}
   public virtual void OnListBoxAutomationPeerNode(XXmlNode xnode) {}
   public virtual void OnListBoxltemNode(XXmlNode xnode) {}
   public virtual void OnListBoxItemAutomationPeerNode(XXmlNode xnode) {}
   public virtual void OnListBoxItemWrapperAutomationPecerNode(XXmlNode xnode) {}
   public virtual void OnListColectionViewNode(XXmlNode xnode) {}
   public virtual void OnListItemNode(XXmlNode xnode) {}
   public virtual void OnListitemStructureNode(XXmlNode xnode) {}
   public virtual void OnListStructureNode(XXmlNode xnode) {}
   public virtual void OnListViewNode(XXmlNode xnode) {}
   public virtual void OnListViewAutomationPeerNode(XXmlNode xnode) {}
   public virtual void OnListViewItemNode(XXmlNode xnode) {}
   public virtual void OnLostFocusEventManagerNode(XXmlNode xnode) {}
   public virtual void OnManipulationBoundaryFeedbackEvetArgsNode(XXmlNode xnode) {}
   public virtual void OnManipulationCompletedEventArgsNode(XXmlNode xnode) {}
   public virtual void OnManipulationDeltaEventArgsNode(XXmlNode xnode) {}
   public virtual void OnManipulationInertiaStartingEventArgsNode(XXmlNode xnode) {}
   public virtual void OnManipulationStartedEventArgsNode(XXmlNode xnode) {}
   public virtual void OnManıpulationStartingErentArgsNode(XXmlNode xnode) {}
   public virtual void OnMarkupExtensionNode(XXmlNode xnode) {}
   public virtual void OnMaterialNode(XXmlNode xnode) {}
   public virtual void OnMaterialCollectionNode(XXmlNode xnode) {}
   public virtual void OnMaterialGroupNode(XXmlNode xnode) {}
   public virtual void OnMatrix3DValueSerializerNode(XXmlNode xnode) {}
   public virtual void OnMatrixAnimationBaseNode(XXmlNode xnode) {}
   public virtual void OnMatrixAnimationUsingKeyFramesNode(XXmlNode xnode) {}
   public virtual void OnMatrixAnimationUsingPathNode(XXmlNode xnode) {}
   public virtual void OnMatrixCameraNode(XXmlNode xnode) {}
   public virtual void OnMatrixKeyFrameNode(XXmlNode xnode) {}
   public virtual void OnMatrixKeyFrameCollectionNode(XXmlNode xnode) {}
   public virtual void OnMatrixTransformNode(XXmlNode xnode) {}
   public virtual void OnMatrixTransform3DNode(XXmlNode xnode) {}
   public virtual void OnMatrixValueSerializerNode(XXmlNode xnode) {}
   public virtual void OnMediaClockNode(XXmlNode xnode) {}
   public virtual void OnMediaElementNode(XXmlNode xnode) {}
   public virtual void OnMediaElementAutomationPeerNode(XXmlNode xnode) {}
   public virtual void OnMediaPlayerNode(XXmlNode xnode) {}
   public virtual void OnMediaScriptCommandRoutedEventArgsNode(XXmlNode xnode) {}
   public virtual void OnMediaTimelineNode(XXmlNode xnode) {}
   public virtual void OnMemberDefinitionNode(XXmlNode xnode) {}
   public virtual void OnMenuNode(XXmlNode xnode) {}
   public virtual void OnMenuAutomationPeerNode(XXmlNode xnode) {}
   public virtual void OnMenuBaseNode(XXmlNode xnode) {}
   public virtual void OnMenuItemNode(XXmlNode xnode) {}
   public virtual void OnMenuItemAutomationPeerNode(XXmlNode xnode) {}
   public virtual void OnMeshGeometry3DNode(XXmlNode xnode) {}
   public virtual void OnModel3DNode(XXmlNode xnode) {}
   public virtual void OnModel3DCollectionNode(XXmlNode xnode) {}
   public virtual void OnModel3DGroupNode(XXmlNode xnode) {}
   public virtual void OnModelUIElement3DNode(XXmlNode xnode) {}
   public virtual void OnModelVisual3DNode(XXmlNode xnode) {}
   public virtual void OnModifierKeysValueSerializerNode(XXmlNode xnode) {}
   public virtual void OnMouseActionValueSerializerNode(XXmlNode xnode) {}
   public virtual void OnMouseBindingNode(XXmlNode xnode) {}
   public virtual void OnMouseButtonEventArgsNode(XXmlNode xnode) {}
   public virtual void OnMouseDeviceNode(XXmlNode xnode) {}
   public virtual void OnMouseDragElementBehaviorNode(XXmlNode xnode) {}
   public virtual void OnMouseEventArgsNode(XXmlNode xnode) {}
   public virtual void OnMouseGestureNode(XXmlNode xnode) {}
   public virtual void OnMouseGestureValueSerializerNode(XXmlNode xnode) {}
   public virtual void OnMouseWheelEventArgsNode(XXmlNode xnode) {}
   public virtual void OnMultiBindingNode(XXmlNode xnode) {}
   public virtual void OnMultiBindingExpressionNode(XXmlNode xnode) {}
   public virtual void OnMultiDataTriggerNode(XXmlNode xnode) {}
   public virtual void OnMultiSelectorNode(XXmlNode xnode) {}
   public virtual void OnMultiTriggerNode(XXmlNode xnode) {}
   public virtual void OnNamedElementNode(XXmlNode xnode) {}
   public virtual void OnNavigationWindowNode(XXmlNode xnode) {}
   public virtual void OnNavigationWindowAutomationPeerNode(XXmlNode xnode) {}
   public virtual void OnNotifyDataErrorValidationRuleNode(XXmlNode xnode) {}
   public virtual void OnNotifyInputEventArgsNode(XXmlNode xnode) {}
   public virtual void OnNullExtensionNode(XXmlNode xnode) {}
   public virtual void OnObjectAnimationBaseNode(XXmlNode xnode) {}
   public virtual void OnObjectAnimationUsingKeyFramesNode(XXmlNode xnode) {}
   public virtual void OnObjectDataProviderNode(XXmlNode xnode) {}
   public virtual void OnObjectKeyFrameNode(XXmlNode xnode) {}
   public virtual void OnObjectKeyFrameCollectionNode(XXmlNode xnode) {}
   public virtual void OnOpenFileDialogNode(XXmlNode xnode) {}
   public virtual void OnOrthographicCameraNode(XXmlNode xnode) {}
   public virtual void OnOuterGlowBitmapEffectNode(XXmlNode xnode) {}
   public virtual void OnPackageNode(XXmlNode xnode) {}
   public virtual void OnPackagePartNode(XXmlNode xnode) {}
   public virtual void OnPageNode(XXmlNode xnode) {}
   public virtual void OnPageContentNode(XXmlNode xnode) {}
   public virtual void OnPageFunctionNode(XXmlNode xnode) {}
   public virtual void OnPageFunctionBaseNode(XXmlNode xnode) {}
   public virtual void OnPanelNode(XXmlNode xnode) {}
   public virtual void OnParagraphNode(XXmlNode xnode) {}
   public virtual void OnParagraphStructureNode(XXmlNode xnode) {}
   public virtual void OnParallelTimelineNode(XXmlNode xnode) {}
   public virtual void OnPasswordBoxNode(XXmlNode xnode) {}
   public virtual void OnPasswordBoxAutomationPeerNode(XXmlNode xnode) {}
   public virtual void OnPathNode(XXmlNode xnode) {}
   public virtual void OnPathFigureNode(XXmlNode xnode) {}
   public virtual void OnPathFigureCollectionNode(XXmlNode xnode) {}
   public virtual void OnPathFigureCollectionValueSenalizerNode(XXmlNode xnode) {}
   public virtual void OnPathGeometryNode(XXmlNode xnode) {}
   public virtual void OnPathSegmentNode(XXmlNode xnode) {}
   public virtual void OnPathSegmentCollectionNode(XXmlNode xnode) {}
   public virtual void OnPauseStoryboardNode(XXmlNode xnode) {}
   public virtual void OnPenNode(XXmlNode xnode) {}
   public virtual void OnPerspectiveCameraNode(XXmlNode xnode) {}
   public virtual void OnPixelShaderNode(XXmlNode xnode) {}
   public virtual void OnPlaySoundActionNode(XXmlNode xnode) {}
   public virtual void OnPngBitmapDecoderNode(XXmlNode xnode) {}
   public virtual void OnPngBitmapEncoderNode(XXmlNode xnode) {}
   public virtual void OnPoint3DAnimationNode(XXmlNode xnode) {}
   public virtual void OnPoint3DAnimationBaseNode(XXmlNode xnode) {}
   public virtual void OnPoint3DAnimationUsingKeyFramesNode(XXmlNode xnode) {}
   public virtual void OnPoint3DCollectionNode(XXmlNode xnode) {}
   public virtual void OnPoint3DCollectionValueSerializerNode(XXmlNode xnode) {}
   public virtual void OnPoint3DKeyFrameNode(XXmlNode xnode) {}
   public virtual void OnPoint3DKeyFrameCollectionNode(XXmlNode xnode) {}
   public virtual void OnPoint3DValueSerializerNode(XXmlNode xnode) {}
   public virtual void OnPoint4DValueSerializerNode(XXmlNode xnode) {}
   public virtual void OnPointAnimationNode(XXmlNode xnode) {}
   public virtual void OnPointAnimationBaseNode(XXmlNode xnode) {}
   public virtual void OnPointAnimationUsingKeyFramesNode(XXmlNode xnode) {}
   public virtual void OnPointAnimationUsingPathNode(XXmlNode xnode) {}
   public virtual void OnPointCollectionNode(XXmlNode xnode) {}
   public virtual void OnPointCollectionValueSerializerNode(XXmlNode xnode) {}
   public virtual void OnPointHitTestParametersNode(XXmlNode xnode) {}
   public virtual void OnPointHitTestResultNode(XXmlNode xnode) {}
   public virtual void OnPointIListConverterNode(XXmlNode xnode) {}
   public virtual void OnPointKeyFrameNode(XXmlNode xnode) {}
   public virtual void OnPointKeyFrameCollectionNode(XXmlNode xnode) {}
   public virtual void OnPointLightNode(XXmlNode xnode) {}
   public virtual void OnPointLightBaseNode(XXmlNode xnode) {}
   public virtual void OnPointValueSerializerNode(XXmlNode xnode) {}
   public virtual void OnPolyBezierSegmentNode(XXmlNode xnode) {}
   public virtual void OnPolygonNode(XXmlNode xnode) {}
   public virtual void OnPolylıneNode(XXmlNode xnode) {}
   public virtual void OnPolyLineSegmentNode(XXmlNode xnode) {}
   public virtual void OnPolyQuadraticBezierSegmentNode(XXmlNode xnode) {}
   public virtual void OnPopupNode(XXmlNode xnode) {}
   public virtual void OnPowerEaseNode(XXmlNode xnode) {}
   public virtual void OnPreProcessInputEventArgsNode(XXmlNode xnode) {}
   public virtual void OnPresentationSourceNode(XXmlNode xnode) {}
   public virtual void OnPriorityBindingNode(XXmlNode xnode) {}
   public virtual void OnPriorityBindingExpressionNode(XXmlNode xnode) {}
   public virtual void OnProcessInputEventArgsNode(XXmlNode xnode) {}
   public virtual void OnProgressBarNode(XXmlNode xnode) {}
   public virtual void OnProgressBarAutomattonPeerNode(XXmlNode xnode) {}
   public virtual void OnProjectionCameraNode(XXmlNode xnode) {}
   public virtual void OnPropertyChangedEventManagerNode(XXmlNode xnode) {}
   public virtual void OnPropertyChangedTriggerNode(XXmlNode xnode) {}
   public virtual void OnPropertyDefinitionNode(XXmlNode xnode) {}
   public virtual void OnPropertyGroupDescriptionNode(XXmlNode xnode) {}
   public virtual void OnPropertyMetadataNode(XXmlNode xnode) {}
   public virtual void OnQuadraticBezierSegmentNode(XXmlNode xnode) {}
   public virtual void OnOuadraticEaseNode(XXmlNode xnode) {}
   public virtual void OnQuarticEaseNode(XXmlNode xnode) {}
   public virtual void OnQuaternionAnimationNode(XXmlNode xnode) {}
   public virtual void OnQuaternionAnimationBaseNode(XXmlNode xnode) {}
   public virtual void OnQuaternionAnimationUsingKeyFramesNode(XXmlNode xnode) {}
   public virtual void OnQuaternionKeyFrameNode(XXmlNode xnode) {}
   public virtual void OnQuaternionKeyFrameCollectionNode(XXmlNode xnode) {}
   public virtual void OnQuaternionRotation3DNode(XXmlNode xnode) {}
   public virtual void OnQuaternionValueSerializerNode(XXmlNode xnode) {}
   public virtual void OnQueryContinueDragEventArgsNode(XXmlNode xnode) {}
   public virtual void OnQueryCursorEventArgsNode(XXmlNode xnode) {}
   public virtual void OnQuinticEaseNode(XXmlNode xnode) {}
   public virtual void OnRadialGradientBrushNode(XXmlNode xnode) {}
   public virtual void OnRadioButtonNode(XXmlNode xnode) {}
   public virtual void OnRadioButtonAutomationPeerNode(XXmlNode xnode) {}
   public virtual void OnRangeBaseNode(XXmlNode xnode) {}
   public virtual void OnRangeBaseAutomationPeerNode(XXmlNode xnode) {}
   public virtual void OnRayHitTestParametersNode(XXmlNode xnode) {}
   public virtual void OnRayHitTestResultNode(XXmlNode xnode) {}
   public virtual void OnRayMeshGeometry3DHitTestResultNode(XXmlNode xnode) {}
   public virtual void OnRect3DValueSerializerNode(XXmlNode xnode) {}
   public virtual void OnRectangleNode(XXmlNode xnode) {}
   public virtual void OnRectangleGeometryNode(XXmlNode xnode) {}
   public virtual void OnRectangleStylusShapeNode(XXmlNode xnode) {}
   public virtual void OnRectAnimationNode(XXmlNode xnode) {}
   public virtual void OnRectAnimationBaseNode(XXmlNode xnode) {}
   public virtual void OnRectAnimationUsingKeyFramesNode(XXmlNode xnode) {}
   public virtual void OnRectKeyFrameNode(XXmlNode xnode) {}
   public virtual void OnRectKeyFrameCollectionNode(XXmlNode xnode) {}
   public virtual void OnRectValueSerializerNode(XXmlNode xnode) {}
   public virtual void OnReferenceNode(XXmlNode xnode) {}
   public virtual void OnRelativeSourceNode(XXmlNode xnode) {}
   public virtual void OnRemoveElementActionNode(XXmlNode xnode) {}
   public virtual void OnRemoveStoryboardNode(XXmlNode xnode) {}
   public virtual void OnRenderTargetBitmapNode(XXmlNode xnode) {}
   public virtual void OnRepeteButtonNode(XXmlNode xnode) {}
   public virtual void OnRepeatButtonAutomationPeerNode(XXmlNode xnode) {}
   public virtual void OnRequestBringIntoViewEventArgsNode(XXmlNode xnode) {}
   public virtual void OnRequestNavigateEventArgsNode(XXmlNode xnode) {}
   public virtual void OnResizeGripNode(XXmlNode xnode) {}
   public virtual void OnResourceKeyNode(XXmlNode xnode) {}
   public virtual void OnResourceReferenceExpressionConverterNode(XXmlNode xnode) {}
   public virtual void OnResumeStoryboardNode(XXmlNode xnode) {}
   public virtual void OnRichTextBoxNode(XXmlNode xnode) {}
   public virtual void OnRichTextBoxAutomationPeerNode(XXmlNode xnode) {}
   public virtual void OnRotateTransformNode(XXmlNode xnode) {}
   public virtual void OnRotateTransform3DNode(XXmlNode xnode) {}
   public virtual void OnRotation3DNode(XXmlNode xnode) {}
   public virtual void OnRotation3DAnimationNode(XXmlNode xnode) {}
   public virtual void OnRotation3DAnimationBaseNode(XXmlNode xnode) {}
   public virtual void OnRotation3DAnimationUsingKeyFramesNode(XXmlNode xnode) {}
   public virtual void OnRotation3DKeyFrameNode(XXmlNode xnode) {}
   public virtual void OnRotation3DKeyFrameCollectionNode(XXmlNode xnode) {}
   public virtual void OnRoutedCommandNode(XXmlNode xnode) {}
   public virtual void OnRoutedEventArgsNode(XXmlNode xnode) {}
   public virtual void OnRoutedPropertyChangedEventArgsNode(XXmlNode xnode) {}
   public virtual void OnRoutedUICommandNode(XXmlNode xnode) {}
   public virtual void OnRowDefinitionNode(XXmlNode xnode) {}
   public virtual void OnRunNode(XXmlNode xnode) {}
   public virtual void OnSaveFileDialogNode(XXmlNode xnode) {}
   public virtual void OnScaleTransformNode(XXmlNode xnode) {}
   public virtual void OnScaleTransform3DNode(XXmlNode xnode) {}
   public virtual void OnScrollBarNode(XXmlNode xnode) {}
   public virtual void OnScrollBarAutomationPeerNode(XXmlNode xnode) {}
   public virtual void OnScrollChangedEventArgsNode(XXmlNode xnode) {}
   public virtual void OnScrollContentPresenterNode(XXmlNode xnode) {}
   public virtual void OnSerollEventArgsNode(XXmlNode xnode) {}
   public virtual void OnScrollViewerNode(XXmlNode xnode) {}
   public virtual void OnScrollViewerAutomationPeerNode(XXmlNode xnode) {}
   public virtual void OnSectionNode(XXmlNode xnode) {}
   public virtual void OnSectionStructureNode(XXmlNode xnode) {}
   public virtual void OnSeekStoryboardNode(XXmlNode xnode) {}
   public virtual void OnSelectionChangedEventArgsNode(XXmlNode xnode) {}
   public virtual void OnSelectiveScrollingGridNode(XXmlNode xnode) {}
   public virtual void OnSelectorNode(XXmlNode xnode) {}
   public virtual void OnSelectorAutomationPeerNode(XXmlNode xnode) {}
   public virtual void OnSelectorItemAutomationPeerNode(XXmlNode xnode) {}
   public virtual void OnSemanticBasicElementNode(XXmlNode xnode) {}
   public virtual void OnSeparatorNode(XXmlNode xnode) {}
   public virtual void OnSeparatorAutomationPeerNode(XXmlNode xnode) {}
   public virtual void OnServiceProvidersNode(XXmlNode xnode) {}
   public virtual void OnSetDataStoreValueActionNode(XXmlNode xnode) {}
   public virtual void OnSetStoryboardSpeedRatioNode(XXmlNode xnode) {}
   public virtual void OnSetterNode(XXmlNode xnode) {}
   public virtual void OnSetterBaseNode(XXmlNode xnode) {}
   public virtual void OnShaderEfectNode(XXmlNode xnode) {}
   public virtual void OnShapeNode(XXmlNode xnode) {}
   public virtual void OnSineEaseNode(XXmlNode xnode) {}
   public virtual void OnSingleAnimationNode(XXmlNode xnode) {}
   public virtual void OnSingleAnimationBaseNode(XXmlNode xnode) {}
   public virtual void OnSingleAnimationUsingKeyFramesNode(XXmlNode xnode) {}
   public virtual void OnSingleKeyFrameNode(XXmlNode xnode) {}
   public virtual void OnSingleKeyFrameCollectionNode(XXmlNode xnode) {}
   public virtual void OnSize3DValueSerializerNode(XXmlNode xnode) {}
   public virtual void OnSizeAnimationNode(XXmlNode xnode) {}
   public virtual void OnSizeAnimationBaseNode(XXmlNode xnode) {}
   public virtual void OnSizeAnimationUsingKeyFramesNode(XXmlNode xnode) {}
   public virtual void OnSizeChangedEventArgsNode(XXmlNode xnode) {}
   public virtual void OnSizeKeyFrameNode(XXmlNode xnode) {}
   public virtual void OnSizeKeyFrameCollectionNode(XXmlNode xnode) {}
   public virtual void OnSizeValueSerializerNode(XXmlNode xnode) {}
   public virtual void OnSkewTransformNode(XXmlNode xnode) {}
   public virtual void OnSkipStoryboardToFillNode(XXmlNode xnode) {}
   public virtual void OnSliderNode(XXmlNode xnode) {}
   public virtual void OnSiderAutomationPeerNode(XXmlNode xnode) {}
   public virtual void OnSolidColorBrushNode(XXmlNode xnode) {}
   public virtual void OnSoundPlayerActionNode(XXmlNode xnode) {}
   public virtual void OnSourceChangedEventArgsNode(XXmlNode xnode) {}
   public virtual void OnSpanNode(XXmlNode xnode) {}
   public virtual void OnSpecularMaterialNode(XXmlNode xnode) {}
   public virtual void OnSplineByteKeyFrameNode(XXmlNode xnode) {}
   public virtual void OnSplıneColorKeyFrameNode(XXmlNode xnode) {}
   public virtual void OnSplineDecimalKeyFrameNode(XXmlNode xnode) {}
   public virtual void OnSplineDoubleKeyFrameNode(XXmlNode xnode) {}
   public virtual void OnSplinelnt16KeyFrameNode(XXmlNode xnode) {}
   public virtual void OnSplinelnt32KeyFrameNode(XXmlNode xnode) {}
   public virtual void OnSplinelnt64KeyFrameNode(XXmlNode xnode) {}
   public virtual void OnSplinePoint3DKeyFrameNode(XXmlNode xnode) {}
   public virtual void OnSplinePointKevFrameNode(XXmlNode xnode) {}
   public virtual void OnSplineQuaternionKeyFrameNode(XXmlNode xnode) {}
   public virtual void OnSplineRectKeyFrameNode(XXmlNode xnode) {}
   public virtual void OnSplineRotation3DKeyFrameNode(XXmlNode xnode) {}
   public virtual void OnSplineSingleKeyFrameNode(XXmlNode xnode) {}
   public virtual void OnSplineSizeKeyFrameNode(XXmlNode xnode) {}
   public virtual void OnSplineThicknessKeyFrameNode(XXmlNode xnode) {}
   public virtual void OnSplineVector3DKeyFrameNode(XXmlNode xnode) {}
   public virtual void OnSplineVectorKeyFrameNode(XXmlNode xnode) {}
   public virtual void OnSpotLightNode(XXmlNode xnode) {}
   public virtual void OnStackPanelNode(XXmlNode xnode) {}
   public virtual void OnStaticExtensionNode(XXmlNode xnode) {}
   public virtual void OnStaticResourceExtensionNode(XXmlNode xnode) {}
   public virtual void OnStatusBarNode(XXmlNode xnode) {}
   public virtual void OnStatusBarAutomationPeerNode(XXmlNode xnode) {}
   public virtual void OnStatusBarItemNode(XXmlNode xnode) {}
   public virtual void OnStatusBarItemAutomationPeerNode(XXmlNode xnode) {}
   public virtual void OnStickyNoteControlNode(XXmlNode xnode) {}
   public virtual void OnStopStoryboardNode(XXmlNode xnode) {}
   public virtual void OnStoryboardNode(XXmlNode xnode) {}
   public virtual void OnStoryboardActionNode(XXmlNode xnode) {}
   public virtual void OnStoryboardCompletedTriggerNode(XXmlNode xnode) {}
   public virtual void OnStoryboardTriggerNode(XXmlNode xnode) {}
   public virtual void OnStoryBreakNode(XXmlNode xnode) {}
   public virtual void OnStreamGeometryNode(XXmlNode xnode) {}
   public virtual void OnStreamGeometryContextNode(XXmlNode xnode) {}
   public virtual void OnStringAnimationBaseNode(XXmlNode xnode) {}
   public virtual void OnStringAnimationUsingKevFramesNode(XXmlNode xnode) {}
   public virtual void OnStringKeyFrameNode(XXmlNode xnode) {}
   public virtual void OnStringKeyFrameCollectionNode(XXmlNode xnode) {}
   public virtual void OnStyleNode(XXmlNode xnode) {}
   public virtual void OnStylusButtonEventArgsNode(XXmlNode xnode) {}
   public virtual void OnStylusDeviceNode(XXmlNode xnode) {}
   public virtual void OnStylusDownEventArgsNode(XXmlNode xnode) {}
   public virtual void OnStylusPlugInNode(XXmlNode xnode) {}
   public virtual void OnStylusEventArgsNode(XXmlNode xnode) {}
   public virtual void OnStylusPontPropertyNode(XXmlNode xnode) {}
   public virtual void OnStylusPointPropertyInfoNode(XXmlNode xnode) {}
   public virtual void OnStylusShapeNode(XXmlNode xnode) {}
   public virtual void OnStylusSystemGestureEventArgsNode(XXmlNode xnode) {}
   public virtual void OnTabControlNode(XXmlNode xnode) {}
   public virtual void OnTabControlAutomationPeerNode(XXmlNode xnode) {}
   public virtual void OnTabIternNode(XXmlNode xnode) {}
   public virtual void OnTabItenAutomationPeerNode(XXmlNode xnode) {}
   public virtual void OnTabItemWrapperAutomationPeerNode(XXmlNode xnode) {}
   public virtual void OnTableNode(XXmlNode xnode) {}
   public virtual void OnTableAutomationPeerNode(XXmlNode xnode) {}
   public virtual void OnTableCellNode(XXmlNode xnode) {}
   public virtual void OnTableCellAutomationPeerNode(XXmlNode xnode) {}
   public virtual void OnTableCellStructureNode(XXmlNode xnode) {}
   public virtual void OnTableColumnNode(XXmlNode xnode) {}
   public virtual void OnTableRowNode(XXmlNode xnode) {}
   public virtual void OnTableRowGroupNode(XXmlNode xnode) {}
   public virtual void OnTableRowGroupStructureNode(XXmlNode xnode) {}
   public virtual void OnTableRowStructureNode(XXmlNode xnode) {}
   public virtual void OnTableStructureNode(XXmlNode xnode) {}
   public virtual void OnTabletDeviceNode(XXmlNode xnode) {}
   public virtual void OnTabPanelNode(XXmlNode xnode) {}
   public virtual void OnTargetedTriggerActionNode(XXmlNode xnode) {}
   public virtual void OnTaskbarltemInfoNode(XXmlNode xnode) {}
   public virtual void OnTemplateBindingExpressionNode(XXmlNode xnode) {}
   public virtual void OnTemplateBindingExtensionNode(XXmlNode xnode) {}
   public virtual void OnTemplateContentLoaderNode(XXmlNode xnode) {}
   public virtual void OnTemplateKeyNode(XXmlNode xnode) {}
   public virtual void OnTextAutomationPeerNode(XXmlNode xnode) {}
   public virtual void OnTextBlockNode(XXmlNode xnode) {}
   public virtual void OnTextBlockAutomationPeerNode(XXmlNode xnode) {}
   public virtual void OnTextBoxNode(XXmlNode xnode) {}
   public virtual void OnTextBoxAutomationPeerNode(XXmlNode xnode) {}
   public virtual void OnTextBoxBaseNode(XXmlNode xnode) {}
   public virtual void OnTextChangedEventArgsNode(XXmlNode xnode) {}
   public virtual void OnTextCharactersNode(XXmlNode xnode) {}
   public virtual void OnTextCollapsingPropertiesNode(XXmlNode xnode) {}
   public virtual void OnTextComposıtionNode(XXmlNode xnode) {}
   public virtual void OnTextCompositionEventArgsNode(XXmlNode xnode) {}
   public virtual void OnTextCompositionManagerNode(XXmlNode xnode) {}
   public virtual void OnTextDecorationNode(XXmlNode xnode) {}
   public virtual void OnTextDecorationCollectionNode(XXmlNode xnode) {}
   public virtual void OnTextEffectNode(XXmlNode xnode) {}
   public virtual void OnTextEftectCollectionNode(XXmlNode xnode) {}
   public virtual void OnTextElementNode(XXmlNode xnode) {}
   public virtual void OnTextElementAutomationPeerNode(XXmlNode xnode) {}
   public virtual void OnTextEmbeddedObjectNode(XXmlNode xnode) {}
   public virtual void OnTextEndOfLineNode(XXmlNode xnode) {}
   public virtual void OnTextEndOfParagraphNode(XXmlNode xnode) {}
   public virtual void OnTextEndOfSegmentNode(XXmlNode xnode) {}
   public virtual void OnTextHiddenNode(XXmlNode xnode) {}
   public virtual void OnTextMarkerPropertiesNode(XXmlNode xnode) {}
   public virtual void OnTextModifierNode(XXmlNode xnode) {}
   public virtual void OnTextPointerNode(XXmlNode xnode) {}
   public virtual void OnTextRangeNode(XXmlNode xnode) {}
   public virtual void OnTextRunNode(XXmlNode xnode) {}
   public virtual void OnTextSearchNode(XXmlNode xnode) {}
   public virtual void OnTextSelectionNode(XXmlNode xnode) {}
   public virtual void OnTextSimpleMarkerPropertiesNode(XXmlNode xnode) {}
   public virtual void OnTextTrailingCharacterEllipsisNode(XXmlNode xnode) {}
   public virtual void OnTextTrailingWordEllipsisNode(XXmlNode xnode) {}
   public virtual void OnThemeDictionaryExtensionNode(XXmlNode xnode) {}
   public virtual void OnThicknessAnimationNode(XXmlNode xnode) {}
   public virtual void OnThicknessAnimationBaseNode(XXmlNode xnode) {}
   public virtual void OnThicknessAnimationUsingKeyFramesNode(XXmlNode xnode) {}
   public virtual void OnThicknessKeyFrameNode(XXmlNode xnode) {}
   public virtual void OnThicknessKeyFrameCollectionNode(XXmlNode xnode) {}
   public virtual void OnThumbNode(XXmlNode xnode) {}
   public virtual void OnThumbAutomationPeerNode(XXmlNode xnode) {}
   public virtual void OnThumbButonInfoNode(XXmlNode xnode) {}
   public virtual void OnThumbButtonlnfoCollectionNode(XXmlNode xnode) {}
   public virtual void OnTickBarNode(XXmlNode xnode) {}
   public virtual void OnTiffBitmapNode(XXmlNode xnode) {}
   public virtual void OnTiffBitmapEncoderNode(XXmlNode xnode) {}
   public virtual void OnTileBrushNode(XXmlNode xnode) {}
   public virtual void OnTimelineNode(XXmlNode xnode) {}
   public virtual void OnTimelineCollectionNode(XXmlNode xnode) {}
   public virtual void OnTimelıneGroupNode(XXmlNode xnode) {}
   public virtual void OnTimerTriggerNode(XXmlNode xnode) {}
   public virtual void OnToggleButtonNode(XXmlNode xnode) {}
   public virtual void OnToggleButtonAutomationPeerNode(XXmlNode xnode) {}
   public virtual void OnToolBarNode(XXmlNode xnode) {}
   public virtual void OnTooIBarAutomationPeerNode(XXmlNode xnode) {}
   public virtual void OnToolBarOverflowPanelNode(XXmlNode xnode) {}
   public virtual void OnToolBarPanelNode(XXmlNode xnode) {}
   public virtual void OnToolBarTrayNode(XXmlNode xnode) {}
   public virtual void OnToolTipNode(XXmlNode xnode) {}
   public virtual void OnToolTipAutomationPeerNode(XXmlNode xnode) {}
   public virtual void OnToolTipEventArg3GNode(XXmlNode xnode) {}
   public virtual void OnTouchDeviceNode(XXmlNode xnode) {}
   public virtual void OnTouchDeviceArgsNode(XXmlNode xnode) {}
   public virtual void OnTrackNode(XXmlNode xnode) {}
   public virtual void OnTransformNode(XXmlNode xnode) {}
   public virtual void OnTransform3DNode(XXmlNode xnode) {}
   public virtual void OnTransformn3DCollectionNode(XXmlNode xnode) {}
   public virtual void OnTransform3DGroupNode(XXmlNode xnode) {}
   public virtual void OnTransformCollectionNode(XXmlNode xnode) {}
   public virtual void OnTransformedBitmapNode(XXmlNode xnode) {}
   public virtual void OnTransformGroupNode(XXmlNode xnode) {}
   public virtual void OnTransformValueSerializerNode(XXmlNode xnode) {}
   public virtual void OnTransitionEfectNode(XXmlNode xnode) {}
   public virtual void OnTranslateTransformNode(XXmlNode xnode) {}
   public virtual void OnTranslateTransfom3DNode(XXmlNode xnode) {}
   public virtual void OnTranslateZoomRotateBehaviorNode(XXmlNode xnode) {}
   public virtual void OnTreeViewNode(XXmlNode xnode) {}
   public virtual void OnTreeViewAutomationPeerNode(XXmlNode xnode) {}
   public virtual void OnTreeViewDataltemAutomationPeerNode(XXmlNode xnode) {}
   public virtual void OnTreeViewItemNode(XXmlNode xnode) {}
   public virtual void OnTreeViewItemAutomationPeerNode(XXmlNode xnode) {}
   public virtual void OnTriggerNode(XXmlNode xnode) {}
   public virtual void OnTriggerActionNode(XXmlNode xnode) {}
   public virtual void OnTriggerActionCollectionNode(XXmlNode xnode) {}
   public virtual void OnTriggerBaseNode(XXmlNode xnode) {}
   public virtual void OnTriggerCollectionNode(XXmlNode xnode) {}
   public virtual void OnTypeConverterNode(XXmlNode xnode) {}
   public virtual void OnTypeExtensionNode(XXmlNode xnode) {}
   public virtual void OnUIElementNode(XXmlNode xnode) {}
   public virtual void OnUElement3DNode(XXmlNode xnode) {}
   public virtual void OnUIElement3DAutomationPeerNode(XXmlNode xnode) {}
   public virtual void OnUIElementAutomationPeerNode(XXmlNode xnode) {}
   public virtual void OnUIPropertyMetadataNode(XXmlNode xnode) {}
   public virtual void OnUnderlineNode(XXmlNode xnode) {}
   public virtual void OnUniformGridNode(XXmlNode xnode) {}
   public virtual void OnUserControlNode(XXmlNode xnode) {}
   public virtual void OnUserControlAutomationPeerNode(XXmlNode xnode) {}
   public virtual void OnUShortlListConverterNode(XXmlNode xnode) {}
   public virtual void OnValidationErrorEventArgsNode(XXmlNode xnode) {}
   public virtual void OnValidationRuleNode(XXmlNode xnode) {}
   public virtual void OnValueSerializerNode(XXmlNode xnode) {}
   public virtual void OnVector3DAnimationNode(XXmlNode xnode) {}
   public virtual void OnVector3DAnimationBaseNode(XXmlNode xnode) {}
   public virtual void OnVector3DAnimationUsingKeyFramesNode(XXmlNode xnode) {}
   public virtual void OnVector3DCollectionNode(XXmlNode xnode) {}
   public virtual void OnVector3DCollectionValueSerializerNode(XXmlNode xnode) {}
   public virtual void OnVector3DKeyFrameNode(XXmlNode xnode) {}
   public virtual void OnVector3DKevFrameCollectionNode(XXmlNode xnode) {}
   public virtual void OnVector3DValueSerializerNode(XXmlNode xnode) {}
   public virtual void OnVectorAnimationNode(XXmlNode xnode) {}
   public virtual void OnVectorAnimationBaseNode(XXmlNode xnode) {}
   public virtual void OnVectorAnimationUsingKeyFramesNode(XXmlNode xnode) {}
   public virtual void OnVectorCollectionNode(XXmlNode xnode) {}
   public virtual void OnVectorCollectionValueSerializerNode(XXmlNode xnode) {}
   public virtual void OnVectorKeyFrameNode(XXmlNode xnode) {}
   public virtual void OnVectorKeyFrameCollectionNode(XXmlNode xnode) {}
   public virtual void OnVectorValueSerializerNode(XXmlNode xnode) {}
   public virtual void OnVideoDrawingNode(XXmlNode xnode) {}
   public virtual void OnViewBaseNode(XXmlNode xnode) {}
   public virtual void OnViewboxNode(XXmlNode xnode) {}
   public virtual void OnViewport2DVisual3DNode(XXmlNode xnode) {}
   public virtual void OnViewport3DNode(XXmlNode xnode) {}
   public virtual void OnViewport3DAutomationPeerNode(XXmlNode xnode) {}
   public virtual void OnViewport3DVisualNode(XXmlNode xnode) {}
   public virtual void OnVrtualizingPanelNode(XXmlNode xnode) {}
   public virtual void OnVtualizingStackPanelNode(XXmlNode xnode) {}
   public virtual void OnVisualNode(XXmlNode xnode) {}
   public virtual void OnVisual3DNode(XXmlNode xnode) {}
   public virtual void OnVisualBrushNode(XXmlNode xnode) {}
   public virtual void OnVisualStateNode(XXmlNode xnode) {}
   public virtual void OnVisualStateGroupNode(XXmlNode xnode) {}
   public virtual void OnVisualStateManagerNode(XXmlNode xnode) {}
   public virtual void OnVisualTargetNode(XXmlNode xnode) {}
   public virtual void OnVisualTransitionNode(XXmlNode xnode) {}
   public virtual void OnWeakEventManagerNode(XXmlNode xnode) {}
   public virtual void OnWebBrowserNode(XXmlNode xnode) {}
   public virtual void OnWindowNode(XXmlNode xnode) {}
   public virtual void OnWindowAutomationPeerNode(XXmlNode xnode) {}
   public virtual void OnWindowChromeNode(XXmlNode xnode) {}
   public virtual void OnWmpBitmapDecoderNode(XXmlNode xnode) {}
   public virtual void OnWmpBitmapEncoderNode(XXmlNode xnode) {}
   public virtual void OnWrapPanelNode(XXmlNode xnode) {}
   public virtual void OnWriteableBitmapNode(XXmlNode xnode) {}
   public virtual void OnXamlBackgroundReaderNode(XXmlNode xnode) {}
   public virtual void OnXamlDeferringLoaderNode(XXmlNode xnode) {}
   public virtual void OnXamlDesignerSernalizationManagerNode(XXmlNode xnode) {}
   public virtual void OnXamlDirectiveNode(XXmlNode xnode) {}
   public virtual void OnXamlDuplicateMemberExceptionNode(XXmlNode xnode) {}
   public virtual void OnXamlExceptionNode(XXmlNode xnode) {}
   public virtual void OnXamlInternalExceptionNode(XXmlNode xnode) {}
   public virtual void OnXamlMemberNode(XXmlNode xnode) {}
   public virtual void OnXamlObjectReaderNode(XXmlNode xnode) {}
   public virtual void OnXamlObjectReaderExceptionNode(XXmlNode xnode) {}
   public virtual void OnXamlObjectReaderSettingsNode(XXmlNode xnode) {}
   public virtual void OnXamlObjectWriterNode(XXmlNode xnode) {}
   public virtual void OnXamlObjectWriterExceptionNode(XXmlNode xnode) {}
   public virtual void OnXamlObjectWriterSettingsNode(XXmlNode xnode) {}
   public virtual void OnXamlParseExceptionNode(XXmlNode xnode) {}
   public virtual void OnXamlReaderNode(XXmlNode xnode) {}
   public virtual void OnXamlReaderSettingsNode(XXmlNode xnode) {}
   public virtual void OnXamlSchemaExceptionNode(XXmlNode xnode) {}
   public virtual void OnXamlSetMarkupExtensionEventArgsNode(XXmlNode xnode) {}
   public virtual void OnXamlSetypeConverterEventArgsNode(XXmlNode xnode) {}
   public virtual void OnXamSetValueEentArgsNode(XXmlNode xnode) {}
   public virtual void OnXamlWriterNode(XXmlNode xnode) {}
   public virtual void OnXamlWriterSettingsNode(XXmlNode xnode) {}
   public virtual void OnXamlXmlReaderNode(XXmlNode xnode) {}
   public virtual void OnXamlXmlReaderSettingsNode(XXmlNode xnode) {}
   public virtual void OnXamlXmlWriterNode(XXmlNode xnode) {}
   public virtual void OnXamlXmlWriterExceptionNode(XXmlNode xnode) {}
   public virtual void OnXamlXmlWriterSettingsNode(XXmlNode xnode) {}
   public virtual void OnXmlDataProviderNode(XXmlNode xnode) {}
   public virtual void OnXmlStreamStoreNode(XXmlNode xnode) {}
   public virtual void OnZipPackageNode(XXmlNode xnode) {}
   public virtual void OnZipPackagePartNode(XXmlNode xnode) {}
   public virtual void OnIdealSoftTextBoxNode(XXmlNode xnode) {}
   public abstract void OnDefaultNode(XXmlNode xnode);

   /// <summary>
   /// Recursively processes an XML attribute and its children. 
   /// It first processes all children, and then calls the 
   /// appropriate ProcessXXXAttribute method based on the node's name.
   /// </summary>
   /// <param name="node">The XXmlNode to process.</param>
   private void ProcessAttributeInternal(XXmlNode xnode, XXmlAttribute xattribute)
   {
       switch(xattribute.Name)
       {
           case "AccessKey":
               OnAccessKeyAttribute(xnode, xattribute);
               break;
           case "AccessKeyProperty":
               OnAccessKeyPropertyAttribute(xnode, xattribute);
               break;
           case "AccessKeyScopeOwner":
               OnAccessKeyScopeOwnerAttribute(xnode, xattribute);
               break;
           case "AccessKeyScopeOwnerProperty":
               OnAccessKeyScopeOwnerPropertyAttribute(xnode, xattribute);
               break;
           case "ActualOffset":
               OnActualOffsetAttribute(xnode, xattribute);
               break;
           case "ActualSize":
               OnActualSizeAttribute(xnode, xattribute);
               break;
           case "AllowDrop":
               OnAllowDropAttribute(xnode, xattribute);
               break;
           case "AllowDropProperty":
               OnAllowDropPropertyAttribute(xnode, xattribute);
               break;
           case "BringIntoViewRequestedEvent":
               OnBringIntoViewRequestedEventAttribute(xnode, xattribute);
               break;
           case "CacheMode":
               OnCacheModeAttribute(xnode, xattribute);
               break;
           case "CacheModeProperty":
               OnCacheModePropertyAttribute(xnode, xattribute);
               break;
           case "CanBeScrollAnchor":
               OnCanBeScrollAnchorAttribute(xnode, xattribute);
               break;
           case "CanBeScrollAnchorProperty":
               OnCanBeScrollAnchorPropertyAttribute(xnode, xattribute);
               break;
           case "CanDrag":
               OnCanDragAttribute(xnode, xattribute);
               break;
           case "CanDragProperty":
               OnCanDragPropertyAttribute(xnode, xattribute);
               break;
           case "CenterPoint":
               OnCenterPointAttribute(xnode, xattribute);
               break;
           case "CharacterReceivedEvent":
               OnCharacterReceivedEventAttribute(xnode, xattribute);
               break;
           case "Clip":
               OnClipAttribute(xnode, xattribute);
               break;
           case "ClipProperty":
               OnClipPropertyAttribute(xnode, xattribute);
               break;
           case "CompositeMode":
               OnCompositeModeAttribute(xnode, xattribute);
               break;
           case "CompositeModeProperty":
               OnCompositeModePropertyAttribute(xnode, xattribute);
               break;
           case "ContextFlyout":
               OnContextFlyoutAttribute(xnode, xattribute);
               break;
           case "ContextFlyoutProperty":
               OnContextFlyoutPropertyAttribute(xnode, xattribute);
               break;
           case "ContextRequestedEvent":
               OnContextRequestedEventAttribute(xnode, xattribute);
               break;
           case "DesiredSize":
               OnDesiredSizeAttribute(xnode, xattribute);
               break;
           case "DoubleTappedEvent":
               OnDoubleTappedEventAttribute(xnode, xattribute);
               break;
           case "DragEnterEvent":
               OnDragEnterEventAttribute(xnode, xattribute);
               break;
           case "DragLeaveEvent":
               OnDragLeaveEventAttribute(xnode, xattribute);
               break;
           case "DragOverEvent":
               OnDragOverEventAttribute(xnode, xattribute);
               break;
           case "DropEvent":
               OnDropEventAttribute(xnode, xattribute);
               break;
           case "ExitDisplayModeOnAccessKeyInvoked":
               OnExitDisplayModeOnAccessKeyInvokedAttribute(xnode, xattribute);
               break;
           case "ExitDisplayModeOnAccessKeyInvokedProperty":
               OnExitDisplayModeOnAccessKeyInvokedPropertyAttribute(xnode, xattribute);
               break;
           case "GettingFocusEvent":
               OnGettingFocusEventAttribute(xnode, xattribute);
               break;
           case "HighContrastAdjustment":
               OnHighContrastAdjustmentAttribute(xnode, xattribute);
               break;
           case "HighContrastAdjustmentProperty":
               OnHighContrastAdjustmentPropertyAttribute(xnode, xattribute);
               break;
           case "HoldingEvent":
               OnHoldingEventAttribute(xnode, xattribute);
               break;
           case "IsAccessKeyScope":
               OnIsAccessKeyScopeAttribute(xnode, xattribute);
               break;
           case "IsAccessKeyScopeProperty":
               OnIsAccessKeyScopePropertyAttribute(xnode, xattribute);
               break;
           case "IsDoubleTapEnabled":
               OnIsDoubleTapEnabledAttribute(xnode, xattribute);
               break;
           case "IsDoubleTapEnabledProperty":
               OnIsDoubleTapEnabledPropertyAttribute(xnode, xattribute);
               break;
           case "IsHitTestVisible":
               OnIsHitTestVisibleAttribute(xnode, xattribute);
               break;
           case "IsHitTestVisibleProperty":
               OnIsHitTestVisiblePropertyAttribute(xnode, xattribute);
               break;
           case "IsHoldingEnabled":
               OnIsHoldingEnabledAttribute(xnode, xattribute);
               break;
           case "IsHoldingEnabledProperty":
               OnIsHoldingEnabledPropertyAttribute(xnode, xattribute);
               break;
           case "IsRightTapEnabled":
               OnIsRightTapEnabledAttribute(xnode, xattribute);
               break;
           case "IsRightTapEnabledProperty":
               OnIsRightTapEnabledPropertyAttribute(xnode, xattribute);
               break;
           case "IsTapEnabled":
               OnIsTapEnabledAttribute(xnode, xattribute);
               break;
           case "IsTapEnabledProperty":
               OnIsTapEnabledPropertyAttribute(xnode, xattribute);
               break;
           case "KeyboardAcceleratorPlacementMode":
               OnKeyboardAcceleratorPlacementModeAttribute(xnode, xattribute);
               break;
           case "KeyboardAcceleratorPlacementModeProperty":
               OnKeyboardAcceleratorPlacementModePropertyAttribute(xnode, xattribute);
               break;
           case "KeyboardAcceleratorPlacementTarget":
               OnKeyboardAcceleratorPlacementTargetAttribute(xnode, xattribute);
               break;
           case "KeyboardAcceleratorPlacementTargetProperty":
               OnKeyboardAcceleratorPlacementTargetPropertyAttribute(xnode, xattribute);
               break;
           case "KeyboardAccelerators":
               OnKeyboardAcceleratorsAttribute(xnode, xattribute);
               break;
           case "KeyDownEvent":
               OnKeyDownEventAttribute(xnode, xattribute);
               break;
           case "KeyTipHorizontalOffset":
               OnKeyTipHorizontalOffsetAttribute(xnode, xattribute);
               break;
           case "KeyTipHorizontalOffsetProperty":
               OnKeyTipHorizontalOffsetPropertyAttribute(xnode, xattribute);
               break;
           case "KeyTipPlacementMode":
               OnKeyTipPlacementModeAttribute(xnode, xattribute);
               break;
           case "KeyTipPlacementModeProperty":
               OnKeyTipPlacementModePropertyAttribute(xnode, xattribute);
               break;
           case "KeyTipTarget":
               OnKeyTipTargetAttribute(xnode, xattribute);
               break;
           case "KeyTipTargetProperty":
               OnKeyTipTargetPropertyAttribute(xnode, xattribute);
               break;
           case "KeyTipVerticalOffset":
               OnKeyTipVerticalOffsetAttribute(xnode, xattribute);
               break;
           case "KeyTipVerticalOffsetProperty":
               OnKeyTipVerticalOffsetPropertyAttribute(xnode, xattribute);
               break;
           case "KeyUpEvent":
               OnKeyUpEventAttribute(xnode, xattribute);
               break;
           case "Lights":
               OnLightsAttribute(xnode, xattribute);
               break;
           case "LightsProperty":
               OnLightsPropertyAttribute(xnode, xattribute);
               break;
           case "LosingFocusEvent":
               OnLosingFocusEventAttribute(xnode, xattribute);
               break;
           case "ManipulationCompletedEvent":
               OnManipulationCompletedEventAttribute(xnode, xattribute);
               break;
           case "ManipulationDeltaEvent":
               OnManipulationDeltaEventAttribute(xnode, xattribute);
               break;
           case "ManipulationInertiaStartingEvent":
               OnManipulationInertiaStartingEventAttribute(xnode, xattribute);
               break;
           case "ManipulationMode":
               OnManipulationModeAttribute(xnode, xattribute);
               break;
           case "ManipulationModeProperty":
               OnManipulationModePropertyAttribute(xnode, xattribute);
               break;
           case "ManipulationStartedEvent":
               OnManipulationStartedEventAttribute(xnode, xattribute);
               break;
           case "ManipulationStartingEvent":
               OnManipulationStartingEventAttribute(xnode, xattribute);
               break;
           case "NoFocusCandidateFoundEvent":
               OnNoFocusCandidateFoundEventAttribute(xnode, xattribute);
               break;
           case "Opacity":
               OnOpacityAttribute(xnode, xattribute);
               break;
           case "OpacityProperty":
               OnOpacityPropertyAttribute(xnode, xattribute);
               break;
           case "OpacityTransition":
               OnOpacityTransitionAttribute(xnode, xattribute);
               break;
           case "PointerCanceledEvent":
               OnPointerCanceledEventAttribute(xnode, xattribute);
               break;
           case "PointerCaptureLostEvent":
               OnPointerCaptureLostEventAttribute(xnode, xattribute);
               break;
           case "PointerCaptures":
               OnPointerCapturesAttribute(xnode, xattribute);
               break;
           case "PointerCapturesProperty":
               OnPointerCapturesPropertyAttribute(xnode, xattribute);
               break;
           case "PointerEnteredEvent":
               OnPointerEnteredEventAttribute(xnode, xattribute);
               break;
           case "PointerExitedEvent":
               OnPointerExitedEventAttribute(xnode, xattribute);
               break;
           case "PointerMovedEvent":
               OnPointerMovedEventAttribute(xnode, xattribute);
               break;
           case "PointerPressedEvent":
               OnPointerPressedEventAttribute(xnode, xattribute);
               break;
           case "PointerReleasedEvent":
               OnPointerReleasedEventAttribute(xnode, xattribute);
               break;
           case "PointerWheelChangedEvent":
               OnPointerWheelChangedEventAttribute(xnode, xattribute);
               break;
           case "PreviewKeyDownEvent":
               OnPreviewKeyDownEventAttribute(xnode, xattribute);
               break;
           case "PreviewKeyUpEvent":
               OnPreviewKeyUpEventAttribute(xnode, xattribute);
               break;
           case "Projection":
               OnProjectionAttribute(xnode, xattribute);
               break;
           case "ProjectionProperty":
               OnProjectionPropertyAttribute(xnode, xattribute);
               break;
           case "RenderSize":
               OnRenderSizeAttribute(xnode, xattribute);
               break;
           case "RenderTransform":
               OnRenderTransformAttribute(xnode, xattribute);
               break;
           case "RenderTransformOrigin":
               OnRenderTransformOriginAttribute(xnode, xattribute);
               break;
           case "RenderTransformOriginProperty":
               OnRenderTransformOriginPropertyAttribute(xnode, xattribute);
               break;
           case "RenderTransformProperty":
               OnRenderTransformPropertyAttribute(xnode, xattribute);
               break;
           case "RightTappedEvent":
               OnRightTappedEventAttribute(xnode, xattribute);
               break;
           case "Rotation":
               OnRotationAttribute(xnode, xattribute);
               break;
           case "RotationAxis":
               OnRotationAxisAttribute(xnode, xattribute);
               break;
           case "RotationTransition":
               OnRotationTransitionAttribute(xnode, xattribute);
               break;
           case "Scale":
               OnScaleAttribute(xnode, xattribute);
               break;
           case "ScaleTransition":
               OnScaleTransitionAttribute(xnode, xattribute);
               break;
           case "Shadow":
               OnShadowAttribute(xnode, xattribute);
               break;
           case "ShadowProperty":
               OnShadowPropertyAttribute(xnode, xattribute);
               break;
           case "TabFocusNavigation":
               OnTabFocusNavigationAttribute(xnode, xattribute);
               break;
           case "TabFocusNavigationProperty":
               OnTabFocusNavigationPropertyAttribute(xnode, xattribute);
               break;
           case "TappedEvent":
               OnTappedEventAttribute(xnode, xattribute);
               break;
           case "Transform3D":
               OnTransform3DAttribute(xnode, xattribute);
               break;
           case "Transform3DProperty":
               OnTransform3DPropertyAttribute(xnode, xattribute);
               break;
           case "TransformMatrix":
               OnTransformMatrixAttribute(xnode, xattribute);
               break;
           case "Transitions":
               OnTransitionsAttribute(xnode, xattribute);
               break;
           case "TransitionsProperty":
               OnTransitionsPropertyAttribute(xnode, xattribute);
               break;
           case "Translation":
               OnTranslationAttribute(xnode, xattribute);
               break;
           case "TranslationTransition":
               OnTranslationTransitionAttribute(xnode, xattribute);
               break;
           case "UIContext":
               OnUIContextAttribute(xnode, xattribute);
               break;
           case "UseLayoutRounding":
               OnUseLayoutRoundingAttribute(xnode, xattribute);
               break;
           case "UseLayoutRoundingProperty":
               OnUseLayoutRoundingPropertyAttribute(xnode, xattribute);
               break;
           case "Visibility":
               OnVisibilityAttribute(xnode, xattribute);
               break;
           case "VisibilityProperty":
               OnVisibilityPropertyAttribute(xnode, xattribute);
               break;
           case "XamlRoot":
               OnXamlRootAttribute(xnode, xattribute);
               break;
           case "XYFocusDownNavigationStrategy":
               OnXYFocusDownNavigationStrategyAttribute(xnode, xattribute);
               break;
           case "XYFocusDownNavigationStrategyProperty":
               OnXYFocusDownNavigationStrategyPropertyAttribute(xnode, xattribute);
               break;
           case "XYFocusKeyboardNavigation":
               OnXYFocusKeyboardNavigationAttribute(xnode, xattribute);
               break;
           case "XYFocusKeyboardNavigationProperty":
               OnXYFocusKeyboardNavigationPropertyAttribute(xnode, xattribute);
               break;
           case "XYFocusLeftNavigationStrategy":
               OnXYFocusLeftNavigationStrategyAttribute(xnode, xattribute);
               break;
           case "XYFocusLeftNavigationStrategyProperty":
               OnXYFocusLeftNavigationStrategyPropertyAttribute(xnode, xattribute);
               break;
           case "XYFocusRightNavigationStrategy":
               OnXYFocusRightNavigationStrategyAttribute(xnode, xattribute);
               break;
           case "XYFocusRightNavigationStrategyProperty":
               OnXYFocusRightNavigationStrategyPropertyAttribute(xnode, xattribute);
               break;
           case "XYFocusUpNavigationStrategy":
               OnXYFocusUpNavigationStrategyAttribute(xnode, xattribute);
               break;
           case "XYFocusUpNavigationStrategyProperty":
               OnXYFocusUpNavigationStrategyPropertyAttribute(xnode, xattribute);
               break;
           //
           default:
               OnDefaultAttribute(xnode, xattribute);
               break;
       }
   }

   public virtual void OnAccessKeyAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnAccessKeyPropertyAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnAccessKeyScopeOwnerAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnAccessKeyScopeOwnerPropertyAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnActualOffsetAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnActualSizeAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnAllowDropAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnAllowDropPropertyAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnBringIntoViewRequestedEventAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnCacheModeAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnCacheModePropertyAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnCanBeScrollAnchorAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnCanBeScrollAnchorPropertyAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnCanDragAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnCanDragPropertyAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnCenterPointAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnCharacterReceivedEventAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnClipAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnClipPropertyAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnCompositeModeAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnCompositeModePropertyAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnContextFlyoutAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnContextFlyoutPropertyAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnContextRequestedEventAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnDesiredSizeAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnDoubleTappedEventAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnDragEnterEventAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnDragLeaveEventAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnDragOverEventAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnDropEventAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnExitDisplayModeOnAccessKeyInvokedAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnExitDisplayModeOnAccessKeyInvokedPropertyAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnGettingFocusEventAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnHighContrastAdjustmentAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnHighContrastAdjustmentPropertyAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnHoldingEventAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnIsAccessKeyScopeAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnIsAccessKeyScopePropertyAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnIsDoubleTapEnabledAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnIsDoubleTapEnabledPropertyAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnIsHitTestVisibleAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnIsHitTestVisiblePropertyAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnIsHoldingEnabledAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnIsHoldingEnabledPropertyAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnIsRightTapEnabledAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnIsRightTapEnabledPropertyAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnIsTapEnabledAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnIsTapEnabledPropertyAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnKeyboardAcceleratorPlacementModeAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnKeyboardAcceleratorPlacementModePropertyAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnKeyboardAcceleratorPlacementTargetAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnKeyboardAcceleratorPlacementTargetPropertyAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnKeyboardAcceleratorsAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnKeyDownEventAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnKeyTipHorizontalOffsetAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnKeyTipHorizontalOffsetPropertyAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnKeyTipPlacementModeAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnKeyTipPlacementModePropertyAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnKeyTipTargetAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnKeyTipTargetPropertyAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnKeyTipVerticalOffsetAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnKeyTipVerticalOffsetPropertyAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnKeyUpEventAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnLightsAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnLightsPropertyAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnLosingFocusEventAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnManipulationCompletedEventAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnManipulationDeltaEventAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnManipulationInertiaStartingEventAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnManipulationModeAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnManipulationModePropertyAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnManipulationStartedEventAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnManipulationStartingEventAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnNoFocusCandidateFoundEventAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnOpacityAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnOpacityPropertyAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnOpacityTransitionAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnPointerCanceledEventAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnPointerCaptureLostEventAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnPointerCapturesAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnPointerCapturesPropertyAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnPointerEnteredEventAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnPointerExitedEventAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnPointerMovedEventAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnPointerPressedEventAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnPointerReleasedEventAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnPointerWheelChangedEventAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnPreviewKeyDownEventAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnPreviewKeyUpEventAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnProjectionAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnProjectionPropertyAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnRenderSizeAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnRenderTransformAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnRenderTransformOriginAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnRenderTransformOriginPropertyAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnRenderTransformPropertyAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnRightTappedEventAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnRotationAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnRotationAxisAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnRotationTransitionAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnScaleAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnScaleTransitionAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnShadowAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnShadowPropertyAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnTabFocusNavigationAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnTabFocusNavigationPropertyAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnTappedEventAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnTransform3DAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnTransform3DPropertyAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnTransformMatrixAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnTransitionsAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnTransitionsPropertyAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnTranslationAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnTranslationTransitionAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnUIContextAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnUseLayoutRoundingAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnUseLayoutRoundingPropertyAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnVisibilityAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnVisibilityPropertyAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnXamlRootAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnXYFocusDownNavigationStrategyAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnXYFocusDownNavigationStrategyPropertyAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnXYFocusKeyboardNavigationAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnXYFocusKeyboardNavigationPropertyAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnXYFocusLeftNavigationStrategyAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnXYFocusLeftNavigationStrategyPropertyAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnXYFocusRightNavigationStrategyAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnXYFocusRightNavigationStrategyPropertyAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnXYFocusUpNavigationStrategyAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public virtual void OnXYFocusUpNavigationStrategyPropertyAttribute(XXmlNode xnode, XXmlAttribute xattribute) {}
   public abstract void OnDefaultAttribute(XXmlNode xnode, XXmlAttribute xattribute);
}
