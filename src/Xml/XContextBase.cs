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
   public void Process(XXmlNode xnode)
   {
       if (xnode.ChildNodes != null)
           foreach (var node in xnode.ChildNodes)
               Process(node);

       ProcessNodeInternal(xnode);
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
           foreach (XXmlNode childNode in xnode.ChildNodes)
               ProcessNodeInternal(childNode);

       switch(xnode.Name)
       {
           case "AccessKeyPressedEventArgs":
               OnAccessKeyPressedEventArgs(xnode);
               break;
           case "AccessText":
               OnAccessText(xnode);
               break;
           case "ActiveXHost":
               OnActiveXHost(xnode);
               break;
           case "AdormedElementPlaceholder":
               OnAdormedElementPlaceholder(xnode);
               break;
           case "Adorner":
               OnAdorner(xnode);
               break;
           case "AdornerContainer":
               OnAdornerContainer(xnode);
               break;
           case "AdornerDecorator":
               OnAdornerDecorator(xnode);
               break;
           case "AdornerHitTestResut":
               OnAdornerHitTestResut(xnode);
               break;
           case "AdornerLayer":
               OnAdornerLayer(xnode);
               break;
           case "AffineTransform3D":
               OnAffineTransform3D(xnode);
               break;
           case "AmbientLight":
               OnAmbientLight(xnode);
               break;
           case "AnchoredBlock":
               OnAnchoredBlock(xnode);
               break;
           case "Animatable":
               OnAnimatable(xnode);
               break;
           case "AnimationClock":
               OnAnimationClock(xnode);
               break;
           case "AnimationTimeline":
               OnAnimationTimeline(xnode);
               break;
           case "AnnotationDocumemtPagnator":
               OnAnnotationDocumemtPagnator(xnode);
               break;
           case "AnnotationService":
               OnAnnotationService(xnode);
               break;
           case "AnnotationStore":
               OnAnnotationStore(xnode);
               break;
           case "Application":
               OnApplication(xnode);
               break;
           case "ArcSegment":
               OnArcSegment(xnode);
               break;
           case "ArrayExtension":
               OnArrayExtension(xnode);
               break;
           case "AttachableCollection":
               OnAttachableCollection(xnode);
               break;
           case "AttachedPropertyBrowsableAttibute":
               OnAttachedPropertyBrowsableAttibute(xnode);
               break;
           case "AttachedPropertyBrowsableForChildrenAttribute":
               OnAttachedPropertyBrowsableForChildrenAttribute(xnode);
               break;
           case "AttachedPropertyBrowsableForTypeAttribute":
               OnAttachedPropertyBrowsableForTypeAttribute(xnode);
               break;
           case "AttachedPropertyBrowsableWhenAttributePresentAttribute":
               OnAttachedPropertyBrowsableWhenAttributePresentAttribute(xnode);
               break;
           case "Attribute":
               OnAttribute(xnode);
               break;
           case "AutomationPeer":
               OnAutomationPeer(xnode);
               break;
           case "AxisAngleRotation3D":
               OnAxisAngleRotation3D(xnode);
               break;
           case "BackEase":
               OnBackEase(xnode);
               break;
           case "Baml2006Reader":
               OnBaml2006Reader(xnode);
               break;
           case "BaseIListConverter":
               OnBaseIListConverter(xnode);
               break;
           case "BeginStoryboard":
               OnBeginStoryboard(xnode);
               break;
           case "Behavior":
               OnBehavior(xnode);
               break;
           case "BehaviorCollection":
               OnBehaviorCollection(xnode);
               break;
           case "BevelBitmapEffect":
               OnBevelBitmapEffect(xnode);
               break;
           case "BezierSegment":
               OnBezierSegment(xnode);
               break;
           case "Binding":
               OnBinding(xnode);
               break;
           case "BindingBase":
               OnBindingBase(xnode);
               break;
           case "BindingExpression":
               OnBindingExpression(xnode);
               break;
           case "BindingExpressionBase":
               OnBindingExpressionBase(xnode);
               break;
           case "BindingGroup":
               OnBindingGroup(xnode);
               break;
           case "BindingListCollectionView":
               OnBindingListCollectionView(xnode);
               break;
           case "BitmapCache":
               OnBitmapCache(xnode);
               break;
           case "BitmapCacheBrush":
               OnBitmapCacheBrush(xnode);
               break;
           case "BitmapDecoder":
               OnBitmapDecoder(xnode);
               break;
           case "BitmapEffect":
               OnBitmapEffect(xnode);
               break;
           case "BitmapEffectCollection":
               OnBitmapEffectCollection(xnode);
               break;
           case "BitmapEffectGroup":
               OnBitmapEffectGroup(xnode);
               break;
           case "BitmapEffectInput":
               OnBitmapEffectInput(xnode);
               break;
           case "BitmapEncoder":
               OnBitmapEncoder(xnode);
               break;
           case "BitmapFrame":
               OnBitmapFrame(xnode);
               break;
           case "BitmapImage":
               OnBitmapImage(xnode);
               break;
           case "BitmapMetadata":
               OnBitmapMetadata(xnode);
               break;
           case "BitmapPalette":
               OnBitmapPalette(xnode);
               break;
           case "BitmapSource":
               OnBitmapSource(xnode);
               break;
           case "Block":
               OnBlock(xnode);
               break;
           case "BlockElement":
               OnBlockElement(xnode);
               break;
           case "BlockUIContainer":
               OnBlockUIContainer(xnode);
               break;
           case "BlurBitmapEffect":
               OnBlurBitmapEffect(xnode);
               break;
           case "BlurEffect":
               OnBlurEffect(xnode);
               break;
           case "BmpBitmapDecoder":
               OnBmpBitmapDecoder(xnode);
               break;
           case "BmpBitmapEncoder":
               OnBmpBitmapEncoder(xnode);
               break;
           case "Bold":
               OnBold(xnode);
               break;
           case "BooleanAnimationBase":
               OnBooleanAnimationBase(xnode);
               break;
           case "BooleanAnimationUsingKeyFrames":
               OnBooleanAnimationUsingKeyFrames(xnode);
               break;
           case "BooleanKeyFrame":
               OnBooleanKeyFrame(xnode);
               break;
           case "BooleanKeyFrameCollection":
               OnBooleanKeyFrameCollection(xnode);
               break;
           case "BoolIListConverter":
               OnBoolIListConverter(xnode);
               break;
           case "Border":
               OnBorder(xnode);
               break;
           case "BounceEase":
               OnBounceEase(xnode);
               break;
           case "Brush":
               OnBrush(xnode);
               break;
           case "BrushValueSerializer":
               OnBrushValueSerializer(xnode);
               break;
           case "BulletDecorator":
               OnBulletDecorator(xnode);
               break;
           case "Button":
               OnButton(xnode);
               break;
           case "ButtonAutomationPeer":
               OnButtonAutomationPeer(xnode);
               break;
           case "ButtonBase":
               OnButtonBase(xnode);
               break;
           case "ButtonBaseAutomationPeer":
               OnButtonBaseAutomationPeer(xnode);
               break;
           case "ByteAnimation":
               OnByteAnimation(xnode);
               break;
           case "ByteAnimationBase":
               OnByteAnimationBase(xnode);
               break;
           case "ByteAnimationUsingKeyFrames":
               OnByteAnimationUsingKeyFrames(xnode);
               break;
           case "ByteKeyFrame":
               OnByteKeyFrame(xnode);
               break;
           case "BytekeyFrameCollection":
               OnBytekeyFrameCollection(xnode);
               break;
           case "CachedBitmap":
               OnCachedBitmap(xnode);
               break;
           case "CacheMode":
               OnCacheMode(xnode);
               break;
           case "CacheModeValueSerializer":
               OnCacheModeValueSerializer(xnode);
               break;
           case "Calendar":
               OnCalendar(xnode);
               break;
           case "CalendarAutomationPeer":
               OnCalendarAutomationPeer(xnode);
               break;
           case "CalendarButton":
               OnCalendarButton(xnode);
               break;
           case "CalendarButtonAutomationPeer":
               OnCalendarButtonAutomationPeer(xnode);
               break;
           case "CalendarDateChangedEventArgs":
               OnCalendarDateChangedEventArgs(xnode);
               break;
           case "CalendarDayButton":
               OnCalendarDayButton(xnode);
               break;
           case "Calendarltem":
               OnCalendarltem(xnode);
               break;
           case "CalendarModeChangedEventArgs":
               OnCalendarModeChangedEventArgs(xnode);
               break;
           case "CallMethodAction":
               OnCallMethodAction(xnode);
               break;
           case "Camera":
               OnCamera(xnode);
               break;
           case "CanExecuteChangedEventManager":
               OnCanExecuteChangedEventManager(xnode);
               break;
           case "CanExecuteRoutedEventArgs":
               OnCanExecuteRoutedEventArgs(xnode);
               break;
           case "Canvas":
               OnCanvas(xnode);
               break;
           case "ChangePropertyAction":
               OnChangePropertyAction(xnode);
               break;
           case "CharAnimationBase":
               OnCharAnimationBase(xnode);
               break;
           case "CharAnimationUsingKeyFrame":
               OnCharAnimationUsingKeyFrame(xnode);
               break;
           case "CharIListConverter":
               OnCharIListConverter(xnode);
               break;
           case "CharKeyFrame":
               OnCharKeyFrame(xnode);
               break;
           case "CharKeyFrameCollection":
               OnCharKeyFrameCollection(xnode);
               break;
           case "CheckBox":
               OnCheckBox(xnode);
               break;
           case "CheckBoxAutomationPeer":
               OnCheckBoxAutomationPeer(xnode);
               break;
           case "CircleEase":
               OnCircleEase(xnode);
               break;
           case "CleanUpVirtualizedItemEventArgs":
               OnCleanUpVirtualizedItemEventArgs(xnode);
               break;
           case "Clock":
               OnClock(xnode);
               break;
           case "ClockController":
               OnClockController(xnode);
               break;
           case "ClockGroup":
               OnClockGroup(xnode);
               break;
           case "CollectionChangedEventManager":
               OnCollectionChangedEventManager(xnode);
               break;
           case "CollectionContainer":
               OnCollectionContainer(xnode);
               break;
           case "CollectionView":
               OnCollectionView(xnode);
               break;
           case "CollectionViewSource":
               OnCollectionViewSource(xnode);
               break;
           case "ColorAnimation":
               OnColorAnimation(xnode);
               break;
           case "ColorAnimationBase":
               OnColorAnimationBase(xnode);
               break;
           case "ColorAnimationUsingKeyFrames":
               OnColorAnimationUsingKeyFrames(xnode);
               break;
           case "ColorConvertedBitmap":
               OnColorConvertedBitmap(xnode);
               break;
           case "ColorConvertedBitmapExtension":
               OnColorConvertedBitmapExtension(xnode);
               break;
           case "ColorKeyFrame":
               OnColorKeyFrame(xnode);
               break;
           case "ColorKeyFrameCollection":
               OnColorKeyFrameCollection(xnode);
               break;
           case "ColorDefinition":
               OnColorDefinition(xnode);
               break;
           case "CombinedGeometry":
               OnCombinedGeometry(xnode);
               break;
           case "ComboBox":
               OnComboBox(xnode);
               break;
           case "ComboBoxAutomationPeer":
               OnComboBoxAutomationPeer(xnode);
               break;
           case "ComboBoxltem":
               OnComboBoxltem(xnode);
               break;
           case "CommonDialog":
               OnCommonDialog(xnode);
               break;
           case "ComparisonCondition":
               OnComparisonCondition(xnode);
               break;
           case "ComponentResourceKey":
               OnComponentResourceKey(xnode);
               break;
           case "ComponentResourceKeyConverter":
               OnComponentResourceKeyConverter(xnode);
               break;
           case "CompositionTarget":
               OnCompositionTarget(xnode);
               break;
           case "ConditionalExpression":
               OnConditionalExpression(xnode);
               break;
           case "ConditionBehavior":
               OnConditionBehavior(xnode);
               break;
           case "ConditionCollection":
               OnConditionCollection(xnode);
               break;
           case "ContainerUIElement3D":
               OnContainerUIElement3D(xnode);
               break;
           case "ContainerVisual":
               OnContainerVisual(xnode);
               break;
           case "ContentControl":
               OnContentControl(xnode);
               break;
           case "ContentElement":
               OnContentElement(xnode);
               break;
           case "ContentElementAutomationPeer":
               OnContentElementAutomationPeer(xnode);
               break;
           case "ContentLocator":
               OnContentLocator(xnode);
               break;
           case "ContentocatorBase":
               OnContentocatorBase(xnode);
               break;
           case "ContentLocatorGroup":
               OnContentLocatorGroup(xnode);
               break;
           case "ContentPosition":
               OnContentPosition(xnode);
               break;
           case "ContentPresenter":
               OnContentPresenter(xnode);
               break;
           case "ContentTextAutomationPeer":
               OnContentTextAutomationPeer(xnode);
               break;
           case "ContextMenu":
               OnContextMenu(xnode);
               break;
           case "ContextMenuAutomationPeer":
               OnContextMenuAutomationPeer(xnode);
               break;
           case "ContextMenuEventArgs":
               OnContextMenuEventArgs(xnode);
               break;
           case "Control":
               OnControl(xnode);
               break;
           case "ControllableStoryboardAction":
               OnControllableStoryboardAction(xnode);
               break;
           case "ControlStoryboardAction":
               OnControlStoryboardAction(xnode);
               break;
           case "ControlTemplate":
               OnControlTemplate(xnode);
               break;
           case "CroppedBitmap":
               OnCroppedBitmap(xnode);
               break;
           case "CubicEase":
               OnCubicEase(xnode);
               break;
           case "CurrentChangedEventManager":
               OnCurrentChangedEventManager(xnode);
               break;
           case "CurrentChangingEventManager":
               OnCurrentChangingEventManager(xnode);
               break;
           case "D3DImage":
               OnD3DImage(xnode);
               break;
           case "DashStyle":
               OnDashStyle(xnode);
               break;
           case "DataChangedEventManager":
               OnDataChangedEventManager(xnode);
               break;
           case "DataErrorValidationRule":
               OnDataErrorValidationRule(xnode);
               break;
           case "DataGrid":
               OnDataGrid(xnode);
               break;
           case "DataGridAutomationPeer":
               OnDataGridAutomationPeer(xnode);
               break;
           case "DataGridBoundColumn":
               OnDataGridBoundColumn(xnode);
               break;
           case "DataGridCell":
               OnDataGridCell(xnode);
               break;
           case "DataGridCellAutomationPeer":
               OnDataGridCellAutomationPeer(xnode);
               break;
           case "DataGridCellItemAutomationPeer":
               OnDataGridCellItemAutomationPeer(xnode);
               break;
           case "DataGridCellsPanel":
               OnDataGridCellsPanel(xnode);
               break;
           case "DataGridCellsPresenter":
               OnDataGridCellsPresenter(xnode);
               break;
           case "DataGridCheckBoxColumn":
               OnDataGridCheckBoxColumn(xnode);
               break;
           case "DataGridColumn":
               OnDataGridColumn(xnode);
               break;
           case "DataGridColumnEventArgs":
               OnDataGridColumnEventArgs(xnode);
               break;
           case "DataGridColumnHeader":
               OnDataGridColumnHeader(xnode);
               break;
           case "DataGridColumnHeaderAutomationPeer":
               OnDataGridColumnHeaderAutomationPeer(xnode);
               break;
           case "DataGridColumnHeaderItemAutomationPeer":
               OnDataGridColumnHeaderItemAutomationPeer(xnode);
               break;
           case "DataGridColumnHeadersPresenter":
               OnDataGridColumnHeadersPresenter(xnode);
               break;
           case "DataGridColumnHeadersPresenterAutomationPeer":
               OnDataGridColumnHeadersPresenterAutomationPeer(xnode);
               break;
           case "DataGridColumnReorderingEventArgs":
               OnDataGridColumnReorderingEventArgs(xnode);
               break;
           case "DataGridComboBoxColumn":
               OnDataGridComboBoxColumn(xnode);
               break;
           case "DataGridDetailsPresenter":
               OnDataGridDetailsPresenter(xnode);
               break;
           case "DataGridDetailsPresenterAutomationPeer":
               OnDataGridDetailsPresenterAutomationPeer(xnode);
               break;
           case "DataGridHyperlinkColumn":
               OnDataGridHyperlinkColumn(xnode);
               break;
           case "DataGridItemAutomationPeer":
               OnDataGridItemAutomationPeer(xnode);
               break;
           case "DataGridRow":
               OnDataGridRow(xnode);
               break;
           case "DataGridRowAutomationPeer":
               OnDataGridRowAutomationPeer(xnode);
               break;
           case "DataGridRowHeader":
               OnDataGridRowHeader(xnode);
               break;
           case "DataGridRowHeaderAutomationPeer":
               OnDataGridRowHeaderAutomationPeer(xnode);
               break;
           case "DataGridRowsPresenter":
               OnDataGridRowsPresenter(xnode);
               break;
           case "DataGridSortingEventArgs":
               OnDataGridSortingEventArgs(xnode);
               break;
           case "DataGridTemplateColumn":
               OnDataGridTemplateColumn(xnode);
               break;
           case "DataGridTextColumn":
               OnDataGridTextColumn(xnode);
               break;
           case "DataObjectCopyingEventArgs":
               OnDataObjectCopyingEventArgs(xnode);
               break;
           case "DataObjectEventArgs":
               OnDataObjectEventArgs(xnode);
               break;
           case "DataObjectPastingEventArgs":
               OnDataObjectPastingEventArgs(xnode);
               break;
           case "DataObjectSettingDataEventArgs":
               OnDataObjectSettingDataEventArgs(xnode);
               break;
           case "DataSourceProvider":
               OnDataSourceProvider(xnode);
               break;
           case "DataStateBehavior":
               OnDataStateBehavior(xnode);
               break;
           case "DataStoreChangedTrigger":
               OnDataStoreChangedTrigger(xnode);
               break;
           case "DataTemplate":
               OnDataTemplate(xnode);
               break;
           case "DataTemplateKey":
               OnDataTemplateKey(xnode);
               break;
           case "DataTransferEventArgs":
               OnDataTransferEventArgs(xnode);
               break;
           case "DataTrigger":
               OnDataTrigger(xnode);
               break;
           case "DatePicker":
               OnDatePicker(xnode);
               break;
           case "DatePickerAutomationPeer":
               OnDatePickerAutomationPeer(xnode);
               break;
           case "DatePickerTextBox":
               OnDatePickerTextBox(xnode);
               break;
           case "DateTimeAutomationPeer":
               OnDateTimeAutomationPeer(xnode);
               break;
           case "DateTimeValueSerializer":
               OnDateTimeValueSerializer(xnode);
               break;
           case "DecimalAnimation":
               OnDecimalAnimation(xnode);
               break;
           case "DecimalAnimationBase":
               OnDecimalAnimationBase(xnode);
               break;
           case "DecimalAnimationUsingKeyFrames":
               OnDecimalAnimationUsingKeyFrames(xnode);
               break;
           case "DecimalKeyFrame":
               OnDecimalKeyFrame(xnode);
               break;
           case "DecimalKeyFrameCollection":
               OnDecimalKeyFrameCollection(xnode);
               break;
           case "Decorator":
               OnDecorator(xnode);
               break;
           case "DefinitionBase":
               OnDefinitionBase(xnode);
               break;
           case "DependencyObject":
               OnDependencyObject(xnode);
               break;
           case "DiffuseMaterial":
               OnDiffuseMaterial(xnode);
               break;
           case "DirectionalLight":
               OnDirectionalLight(xnode);
               break;
           case "DiscreteBooleanKeyFrame":
               OnDiscreteBooleanKeyFrame(xnode);
               break;
           case "DiscreteByteKeyFrame":
               OnDiscreteByteKeyFrame(xnode);
               break;
           case "DiscreteCharKevFrame":
               OnDiscreteCharKevFrame(xnode);
               break;
           case "DiscreteColorKeyFrame":
               OnDiscreteColorKeyFrame(xnode);
               break;
           case "DiscreteDecimalKeyFrame":
               OnDiscreteDecimalKeyFrame(xnode);
               break;
           case "DiscreteDoubleKeyFrame":
               OnDiscreteDoubleKeyFrame(xnode);
               break;
           case "DiscreteInt16KevFrame":
               OnDiscreteInt16KevFrame(xnode);
               break;
           case "DiscreteInt32KeyFrame":
               OnDiscreteInt32KeyFrame(xnode);
               break;
           case "Discretent64KeyFrame":
               OnDiscretent64KeyFrame(xnode);
               break;
           case "DiscretelMatrixKeyFrame":
               OnDiscretelMatrixKeyFrame(xnode);
               break;
           case "DiscereteObjectKeyFrame":
               OnDiscereteObjectKeyFrame(xnode);
               break;
           case "DiscretePoint3DKeyFrame":
               OnDiscretePoint3DKeyFrame(xnode);
               break;
           case "DiscretePointKeyFrame":
               OnDiscretePointKeyFrame(xnode);
               break;
           case "DiscreteQuaternionKeyFrame":
               OnDiscreteQuaternionKeyFrame(xnode);
               break;
           case "DiscreteRectKeyFrame":
               OnDiscreteRectKeyFrame(xnode);
               break;
           case "DiscreteRotation3DKeyFramne":
               OnDiscreteRotation3DKeyFramne(xnode);
               break;
           case "DiscreteSingleKeyFrame":
               OnDiscreteSingleKeyFrame(xnode);
               break;
           case "DiscreteSizeKeyFrame":
               OnDiscreteSizeKeyFrame(xnode);
               break;
           case "DiscreteStringKeyFrame":
               OnDiscreteStringKeyFrame(xnode);
               break;
           case "DiscreteThicknessKeyFrame":
               OnDiscreteThicknessKeyFrame(xnode);
               break;
           case "DiscreteVector3DKeyFrame":
               OnDiscreteVector3DKeyFrame(xnode);
               break;
           case "DiscreteVectorKeyFrame":
               OnDiscreteVectorKeyFrame(xnode);
               break;
           case "DispatcherEventArgs":
               OnDispatcherEventArgs(xnode);
               break;
           case "DispatcherFrame":
               OnDispatcherFrame(xnode);
               break;
           case "DispatcherObject":
               OnDispatcherObject(xnode);
               break;
           case "DispatcherOperation":
               OnDispatcherOperation(xnode);
               break;
           case "DispatcherUnhandledExceptionEventArgs":
               OnDispatcherUnhandledExceptionEventArgs(xnode);
               break;
           case "DispatcherUnhandledExceptionFilterEventArgs":
               OnDispatcherUnhandledExceptionFilterEventArgs(xnode);
               break;
           case "DockPanel":
               OnDockPanel(xnode);
               break;
           case "DocumentAutomationPeer":
               OnDocumentAutomationPeer(xnode);
               break;
           case "DocumentViewerAutomationPeer":
               OnDocumentViewerAutomationPeer(xnode);
               break;
           case "DocumentPageView":
               OnDocumentPageView(xnode);
               break;
           case "DocumentPageViewAutomationPeer":
               OnDocumentPageViewAutomationPeer(xnode);
               break;
           case "DocumentPaginator":
               OnDocumentPaginator(xnode);
               break;
           case "DocumentReference":
               OnDocumentReference(xnode);
               break;
           case "DocumentViewer":
               OnDocumentViewer(xnode);
               break;
           case "DocumentViewerBaseAutomationPeer":
               OnDocumentViewerBaseAutomationPeer(xnode);
               break;
           case "DoCumentViewerBase":
               OnDoCumentViewerBase(xnode);
               break;
           case "DoubleAnimation":
               OnDoubleAnimation(xnode);
               break;
           case "DoubleAnimationBase":
               OnDoubleAnimationBase(xnode);
               break;
           case "DoubleAmimationUsingKevFrames":
               OnDoubleAmimationUsingKevFrames(xnode);
               break;
           case "DoubleAnimationsingPath":
               OnDoubleAnimationsingPath(xnode);
               break;
           case "DoubleCollection":
               OnDoubleCollection(xnode);
               break;
           case "DoubleCollectionValueSenalizer":
               OnDoubleCollectionValueSenalizer(xnode);
               break;
           case "DoubleIListConverter":
               OnDoubleIListConverter(xnode);
               break;
           case "DoubleKeyFrame":
               OnDoubleKeyFrame(xnode);
               break;
           case "DoubleKeyFrameCollection":
               OnDoubleKeyFrameCollection(xnode);
               break;
           case "DragCompletedEventArgs":
               OnDragCompletedEventArgs(xnode);
               break;
           case "DragDeltaEventArgs":
               OnDragDeltaEventArgs(xnode);
               break;
           case "DragEventArgs":
               OnDragEventArgs(xnode);
               break;
           case "DragStartedEventArgs":
               OnDragStartedEventArgs(xnode);
               break;
           case "Drawing":
               OnDrawing(xnode);
               break;
           case "DrawingBrush":
               OnDrawingBrush(xnode);
               break;
           case "DrawingCollection":
               OnDrawingCollection(xnode);
               break;
           case "DrawingContext":
               OnDrawingContext(xnode);
               break;
           case "DrawingGroup":
               OnDrawingGroup(xnode);
               break;
           case "DrawingImage":
               OnDrawingImage(xnode);
               break;
           case "DrawingVisual":
               OnDrawingVisual(xnode);
               break;
           case "DropShadowBitmapEffect":
               OnDropShadowBitmapEffect(xnode);
               break;
           case "DropShadowEffect":
               OnDropShadowEffect(xnode);
               break;
           case "DynamicDocumentPaginator":
               OnDynamicDocumentPaginator(xnode);
               break;
           case "DynamicRenderer":
               OnDynamicRenderer(xnode);
               break;
           case "DynamicResourceExtension":
               OnDynamicResourceExtension(xnode);
               break;
           case "EasingByteKeyFrame":
               OnEasingByteKeyFrame(xnode);
               break;
           case "EasingColorKeyFrame":
               OnEasingColorKeyFrame(xnode);
               break;
           case "EasingDecimalKeyFrame":
               OnEasingDecimalKeyFrame(xnode);
               break;
           case "EasingDoubleKeyFrame":
               OnEasingDoubleKeyFrame(xnode);
               break;
           case "EasingFunctionBase":
               OnEasingFunctionBase(xnode);
               break;
           case "EasingInt16KeyFrame":
               OnEasingInt16KeyFrame(xnode);
               break;
           case "EasingInt32KeyFrame":
               OnEasingInt32KeyFrame(xnode);
               break;
           case "Easinglnt64KeyFrame":
               OnEasinglnt64KeyFrame(xnode);
               break;
           case "EasingPoint3DKeyFrame":
               OnEasingPoint3DKeyFrame(xnode);
               break;
           case "EasingPointKeyFrame":
               OnEasingPointKeyFrame(xnode);
               break;
           case "EasingQuaternionKeyFrame":
               OnEasingQuaternionKeyFrame(xnode);
               break;
           case "EasingRectKeyFrame":
               OnEasingRectKeyFrame(xnode);
               break;
           case "EasingRotation3DKeyFrame":
               OnEasingRotation3DKeyFrame(xnode);
               break;
           case "EasingSingleKeyFrame":
               OnEasingSingleKeyFrame(xnode);
               break;
           case "EasingSizeKeyFranme":
               OnEasingSizeKeyFranme(xnode);
               break;
           case "EasingThicknessKeyFrame":
               OnEasingThicknessKeyFrame(xnode);
               break;
           case "EasıngVector3DKeyFrame":
               OnEasıngVector3DKeyFrame(xnode);
               break;
           case "EasingVectorKeyFrame":
               OnEasingVectorKeyFrame(xnode);
               break;
           case "Effect":
               OnEffect(xnode);
               break;
           case "ElasticEase":
               OnElasticEase(xnode);
               break;
           case "Ellipse":
               OnEllipse(xnode);
               break;
           case "EllipseGeometry":
               OnEllipseGeometry(xnode);
               break;
           case "EllipseStylusShape":
               OnEllipseStylusShape(xnode);
               break;
           case "EmbossBitmapEffect":
               OnEmbossBitmapEffect(xnode);
               break;
           case "EmissiveMaterial":
               OnEmissiveMaterial(xnode);
               break;
           case "ErrorsChangedEventManager":
               OnErrorsChangedEventManager(xnode);
               break;
           case "EventArgs":
               OnEventArgs(xnode);
               break;
           case "EventSetter":
               OnEventSetter(xnode);
               break;
           case "EventTrigger":
               OnEventTrigger(xnode);
               break;
           case "EventTriggerBase":
               OnEventTriggerBase(xnode);
               break;
           case "Exception":
               OnException(xnode);
               break;
           case "ExceptionRoutedEventArgs":
               OnExceptionRoutedEventArgs(xnode);
               break;
           case "ExceptionValidationRule":
               OnExceptionValidationRule(xnode);
               break;
           case "ExecutedRoutedEventArgs":
               OnExecutedRoutedEventArgs(xnode);
               break;
           case "Expander":
               OnExpander(xnode);
               break;
           case "ExpanderAutomationPeer":
               OnExpanderAutomationPeer(xnode);
               break;
           case "ExponentialEase":
               OnExponentialEase(xnode);
               break;
           case "Expression":
               OnExpression(xnode);
               break;
           case "ExpressionConverter":
               OnExpressionConverter(xnode);
               break;
           case "ExtendedVisualStateManager":
               OnExtendedVisualStateManager(xnode);
               break;
           case "Figure":
               OnFigure(xnode);
               break;
           case "FigureStructure":
               OnFigureStructure(xnode);
               break;
           case "FileDialog":
               OnFileDialog(xnode);
               break;
           case "FixedDocument":
               OnFixedDocument(xnode);
               break;
           case "FixedDocumentSequence":
               OnFixedDocumentSequence(xnode);
               break;
           case "FixedPage":
               OnFixedPage(xnode);
               break;
           case "FixedPageAutomationPeer":
               OnFixedPageAutomationPeer(xnode);
               break;
           case "Floater":
               OnFloater(xnode);
               break;
           case "FlowDocument":
               OnFlowDocument(xnode);
               break;
           case "FlowDocumentPageViewer":
               OnFlowDocumentPageViewer(xnode);
               break;
           case "FlowDocumentPageViewerAutomationPeer":
               OnFlowDocumentPageViewerAutomationPeer(xnode);
               break;
           case "FlowDocumentReader":
               OnFlowDocumentReader(xnode);
               break;
           case "FlowDocumentReaderAutomationPeer":
               OnFlowDocumentReaderAutomationPeer(xnode);
               break;
           case "FlowDocumentScrollViewer":
               OnFlowDocumentScrollViewer(xnode);
               break;
           case "FlowDocumentScrollViewerAutomationPeer":
               OnFlowDocumentScrollViewerAutomationPeer(xnode);
               break;
           case "FluidMoveBehavior":
               OnFluidMoveBehavior(xnode);
               break;
           case "FluidMoveBehaviorBase":
               OnFluidMoveBehaviorBase(xnode);
               break;
           case "FluidMoveSetTagBehavior":
               OnFluidMoveSetTagBehavior(xnode);
               break;
           case "FontFamilyValueSerializer":
               OnFontFamilyValueSerializer(xnode);
               break;
           case "FormatConvertedBitmap":
               OnFormatConvertedBitmap(xnode);
               break;
           case "Frame":
               OnFrame(xnode);
               break;
           case "FrameAutomationPeer":
               OnFrameAutomationPeer(xnode);
               break;
           case "FrameworkContentElement":
               OnFrameworkContentElement(xnode);
               break;
           case "FrameworkContentElementAutomationPeer":
               OnFrameworkContentElementAutomationPeer(xnode);
               break;
           case "FrameworkElement":
               OnFrameworkElement(xnode);
               break;
           case "FrameworkElementAutomationPeer":
               OnFrameworkElementAutomationPeer(xnode);
               break;
           case "FrameworkPropertyMetadata":
               OnFrameworkPropertyMetadata(xnode);
               break;
           case "FrameworkRichTextComposition":
               OnFrameworkRichTextComposition(xnode);
               break;
           case "FrameworkTemplate":
               OnFrameworkTemplate(xnode);
               break;
           case "FrameworkTextComposition":
               OnFrameworkTextComposition(xnode);
               break;
           case "Freezable":
               OnFreezable(xnode);
               break;
           case "FreezableCollection":
               OnFreezableCollection(xnode);
               break;
           case "GeneralTransform":
               OnGeneralTransform(xnode);
               break;
           case "GeneralTransform2DTo3D":
               OnGeneralTransform2DTo3D(xnode);
               break;
           case "GeneralTransform3D":
               OnGeneralTransform3D(xnode);
               break;
           case "GeneralTransform3DCollection":
               OnGeneralTransform3DCollection(xnode);
               break;
           case "GeneralTransform3DGroup":
               OnGeneralTransform3DGroup(xnode);
               break;
           case "GeneralTransform3DTo2D":
               OnGeneralTransform3DTo2D(xnode);
               break;
           case "GeneralTransformCollection":
               OnGeneralTransformCollection(xnode);
               break;
           case "GeneralTransformGroup":
               OnGeneralTransformGroup(xnode);
               break;
           case "GenericRootAutomationPeer":
               OnGenericRootAutomationPeer(xnode);
               break;
           case "Geometry":
               OnGeometry(xnode);
               break;
           case "Geometry3D":
               OnGeometry3D(xnode);
               break;
           case "GeometryCollection":
               OnGeometryCollection(xnode);
               break;
           case "GeometryDrawing":
               OnGeometryDrawing(xnode);
               break;
           case "GeometryGroup":
               OnGeometryGroup(xnode);
               break;
           case "GeometryHitTestParameters":
               OnGeometryHitTestParameters(xnode);
               break;
           case "GeometryHitTestResult":
               OnGeometryHitTestResult(xnode);
               break;
           case "GeometryModel3D":
               OnGeometryModel3D(xnode);
               break;
           case "GeometryValueSenalizer":
               OnGeometryValueSenalizer(xnode);
               break;
           case "GestureRecognizer":
               OnGestureRecognizer(xnode);
               break;
           case "GifBitmapDecoder":
               OnGifBitmapDecoder(xnode);
               break;
           case "GifBitmapEncoder":
               OnGifBitmapEncoder(xnode);
               break;
           case "GiveFeedbackEventArgs":
               OnGiveFeedbackEventArgs(xnode);
               break;
           case "GlyphRunDrawing":
               OnGlyphRunDrawing(xnode);
               break;
           case "Glyphs":
               OnGlyphs(xnode);
               break;
           case "GoToStateAction":
               OnGoToStateAction(xnode);
               break;
           case "GradientBrush":
               OnGradientBrush(xnode);
               break;
           case "GradientStop":
               OnGradientStop(xnode);
               break;
           case "GradientStopCollection":
               OnGradientStopCollection(xnode);
               break;
           case "Grid":
               OnGrid(xnode);
               break;
           case "GridSplitter":
               OnGridSplitter(xnode);
               break;
           case "GridSplitterAutomationPeer":
               OnGridSplitterAutomationPeer(xnode);
               break;
           case "GridView":
               OnGridView(xnode);
               break;
           case "GridViewCellAutomationPeer":
               OnGridViewCellAutomationPeer(xnode);
               break;
           case "GridViewColumn":
               OnGridViewColumn(xnode);
               break;
           case "GridViewColumnHeader":
               OnGridViewColumnHeader(xnode);
               break;
           case "GidViewColumnHeaderAutomationPeer":
               OnGidViewColumnHeaderAutomationPeer(xnode);
               break;
           case "GridViewHeaderRowPresenter":
               OnGridViewHeaderRowPresenter(xnode);
               break;
           case "GridViewHeaderRowPresenterAutomationPeer":
               OnGridViewHeaderRowPresenterAutomationPeer(xnode);
               break;
           case "GridViewItemAutomationPeer":
               OnGridViewItemAutomationPeer(xnode);
               break;
           case "GridViewRowPresenter":
               OnGridViewRowPresenter(xnode);
               break;
           case "GridViewRowPresenterBase":
               OnGridViewRowPresenterBase(xnode);
               break;
           case "GroupBox":
               OnGroupBox(xnode);
               break;
           case "GroupBoXAutomationPeer":
               OnGroupBoXAutomationPeer(xnode);
               break;
           case "GroupDescription":
               OnGroupDescription(xnode);
               break;
           case "Groupltem":
               OnGroupltem(xnode);
               break;
           case "GroupItemAutomationPeer":
               OnGroupItemAutomationPeer(xnode);
               break;
           case "GuidelineSet":
               OnGuidelineSet(xnode);
               break;
           case "HeaderedContentControl":
               OnHeaderedContentControl(xnode);
               break;
           case "HeaderedItemsControl":
               OnHeaderedItemsControl(xnode);
               break;
           case "HierarchicalDataTemplate":
               OnHierarchicalDataTemplate(xnode);
               break;
           case "HitTestParameters":
               OnHitTestParameters(xnode);
               break;
           case "HitTestParameters3D":
               OnHitTestParameters3D(xnode);
               break;
           case "HitTestResult":
               OnHitTestResult(xnode);
               break;
           case "HostVisual":
               OnHostVisual(xnode);
               break;
           case "HwndHost":
               OnHwndHost(xnode);
               break;
           case "HwndSource":
               OnHwndSource(xnode);
               break;
           case "HwndTarget":
               OnHwndTarget(xnode);
               break;
           case "Hperlınk":
               OnHperlınk(xnode);
               break;
           case "HyperlinkAutomationPeer":
               OnHyperlinkAutomationPeer(xnode);
               break;
           case "IconBitmapDecoder":
               OnIconBitmapDecoder(xnode);
               break;
           case "Image":
               OnImage(xnode);
               break;
           case "ImageAutomationPeer":
               OnImageAutomationPeer(xnode);
               break;
           case "TmageBrush":
               OnTmageBrush(xnode);
               break;
           case "ImageDrawing":
               OnImageDrawing(xnode);
               break;
           case "Imageetadata":
               OnImageetadata(xnode);
               break;
           case "ImageSource":
               OnImageSource(xnode);
               break;
           case "ImageSourcealueSerializer":
               OnImageSourcealueSerializer(xnode);
               break;
           case "IncrementalHitTester":
               OnIncrementalHitTester(xnode);
               break;
           case "IncrementalLassoHitTester":
               OnIncrementalLassoHitTester(xnode);
               break;
           case "IncrementalStrokehHitTester":
               OnIncrementalStrokehHitTester(xnode);
               break;
           case "InkCanvas":
               OnInkCanvas(xnode);
               break;
           case "InkCanvasAutomationPeer":
               OnInkCanvasAutomationPeer(xnode);
               break;
           case "InkCanvasGestureEventArgs":
               OnInkCanvasGestureEventArgs(xnode);
               break;
           case "InkCanvasStrokeCollectedEventArgs":
               OnInkCanvasStrokeCollectedEventArgs(xnode);
               break;
           case "InkPresenter":
               OnInkPresenter(xnode);
               break;
           case "InkPresenterAutomationPeer":
               OnInkPresenterAutomationPeer(xnode);
               break;
           case "Inline":
               OnInline(xnode);
               break;
           case "InlineUIContainer":
               OnInlineUIContainer(xnode);
               break;
           case "InPlaceBitmapMetadata":
               OnInPlaceBitmapMetadata(xnode);
               break;
           case "InputBindıng":
               OnInputBindıng(xnode);
               break;
           case "InputDevice":
               OnInputDevice(xnode);
               break;
           case "InputEventArgs":
               OnInputEventArgs(xnode);
               break;
           case "InputGesture":
               OnInputGesture(xnode);
               break;
           case "InputanguageChangedEventArgs":
               OnInputanguageChangedEventArgs(xnode);
               break;
           case "InputLanguageChangingEventArgs":
               OnInputLanguageChangingEventArgs(xnode);
               break;
           case "InputanguageEventArgs":
               OnInputanguageEventArgs(xnode);
               break;
           case "InputLanguageManager":
               OnInputLanguageManager(xnode);
               break;
           case "InputManager":
               OnInputManager(xnode);
               break;
           case "InputMethod":
               OnInputMethod(xnode);
               break;
           case "Int16Animation":
               OnInt16Animation(xnode);
               break;
           case "Int16AnimationBase":
               OnInt16AnimationBase(xnode);
               break;
           case "Int16AnimationBaseUsingKeyFrames":
               OnInt16AnimationBaseUsingKeyFrames(xnode);
               break;
           case "Int16KeyFrame":
               OnInt16KeyFrame(xnode);
               break;
           case "Int16KeyFrameCollection":
               OnInt16KeyFrameCollection(xnode);
               break;
           case "Int32Animation":
               OnInt32Animation(xnode);
               break;
           case "Int32AnimationBase":
               OnInt32AnimationBase(xnode);
               break;
           case "Int32AnimationUsingKeyFrames":
               OnInt32AnimationUsingKeyFrames(xnode);
               break;
           case "Int32Collection":
               OnInt32Collection(xnode);
               break;
           case "Int32CollecionValueSerializer":
               OnInt32CollecionValueSerializer(xnode);
               break;
           case "Int32KeyFrame":
               OnInt32KeyFrame(xnode);
               break;
           case "Int32KeyFrameCollection":
               OnInt32KeyFrameCollection(xnode);
               break;
           case "Int32RectValueSernalizer":
               OnInt32RectValueSernalizer(xnode);
               break;
           case "Int64Animation":
               OnInt64Animation(xnode);
               break;
           case "Int64AnimationBase":
               OnInt64AnimationBase(xnode);
               break;
           case "Int64AnimationUsingKeyFrames":
               OnInt64AnimationUsingKeyFrames(xnode);
               break;
           case "Int64KevFrame":
               OnInt64KevFrame(xnode);
               break;
           case "Int64KevFrameCollection":
               OnInt64KevFrameCollection(xnode);
               break;
           case "InteropBitmap":
               OnInteropBitmap(xnode);
               break;
           case "InvokeCommandAction":
               OnInvokeCommandAction(xnode);
               break;
           case "Italic":
               OnItalic(xnode);
               break;
           case "ItemAutomationPeer":
               OnItemAutomationPeer(xnode);
               break;
           case "ItemCollection":
               OnItemCollection(xnode);
               break;
           case "ItemContainerTernplate":
               OnItemContainerTernplate(xnode);
               break;
           case "ItemContainerTemplateKey":
               OnItemContainerTemplateKey(xnode);
               break;
           case "ItemsControl":
               OnItemsControl(xnode);
               break;
           case "ItemsControlAutomationPeer":
               OnItemsControlAutomationPeer(xnode);
               break;
           case "ItemsPanelTernplate":
               OnItemsPanelTernplate(xnode);
               break;
           case "ItemsPresenter":
               OnItemsPresenter(xnode);
               break;
           case "JournalEntry":
               OnJournalEntry(xnode);
               break;
           case "JpegBitmapDecoder":
               OnJpegBitmapDecoder(xnode);
               break;
           case "JpegBitmapEncoder":
               OnJpegBitmapEncoder(xnode);
               break;
           case "JumpItem":
               OnJumpItem(xnode);
               break;
           case "JumpPath":
               OnJumpPath(xnode);
               break;
           case "JumpTask":
               OnJumpTask(xnode);
               break;
           case "KeyBinding":
               OnKeyBinding(xnode);
               break;
           case "KeyboardDevice":
               OnKeyboardDevice(xnode);
               break;
           case "KeyboardEventArgs":
               OnKeyboardEventArgs(xnode);
               break;
           case "KeyboardFocusChangedEventArgs":
               OnKeyboardFocusChangedEventArgs(xnode);
               break;
           case "KeyboardInputPrOviderAcquireFocusEventArgs":
               OnKeyboardInputPrOviderAcquireFocusEventArgs(xnode);
               break;
           case "KeyEventArgs":
               OnKeyEventArgs(xnode);
               break;
           case "KevGesture":
               OnKevGesture(xnode);
               break;
           case "KevGestureValueSerializer":
               OnKevGestureValueSerializer(xnode);
               break;
           case "KeySpline":
               OnKeySpline(xnode);
               break;
           case "KeyTrigger":
               OnKeyTrigger(xnode);
               break;
           case "KeyValueSerializer":
               OnKeyValueSerializer(xnode);
               break;
           case "Label":
               OnLabel(xnode);
               break;
           case "LabelAutomationPeer":
               OnLabelAutomationPeer(xnode);
               break;
           case "LateBoundBitmapDecoder":
               OnLateBoundBitmapDecoder(xnode);
               break;
           case "LaunchUriOrFileAction":
               OnLaunchUriOrFileAction(xnode);
               break;
           case "Light":
               OnLight(xnode);
               break;
           case "Line":
               OnLine(xnode);
               break;
           case "LinearByteKeyFrame":
               OnLinearByteKeyFrame(xnode);
               break;
           case "LinearColorKeyFrame":
               OnLinearColorKeyFrame(xnode);
               break;
           case "LinearDecimalKeyFrame":
               OnLinearDecimalKeyFrame(xnode);
               break;
           case "LinearDoubleKeyFrame":
               OnLinearDoubleKeyFrame(xnode);
               break;
           case "LinearGradientBrush":
               OnLinearGradientBrush(xnode);
               break;
           case "LinearInt16KeyFrame":
               OnLinearInt16KeyFrame(xnode);
               break;
           case "LinearInt32KeyFrame":
               OnLinearInt32KeyFrame(xnode);
               break;
           case "LinearInt64KeyFrame":
               OnLinearInt64KeyFrame(xnode);
               break;
           case "LinearPoint3DKeyFrame":
               OnLinearPoint3DKeyFrame(xnode);
               break;
           case "LinearPointKeyFrame":
               OnLinearPointKeyFrame(xnode);
               break;
           case "LinearQuaternionKeyFrame":
               OnLinearQuaternionKeyFrame(xnode);
               break;
           case "LinearRectKeyFrame":
               OnLinearRectKeyFrame(xnode);
               break;
           case "LinearRotation3DKeyFrame":
               OnLinearRotation3DKeyFrame(xnode);
               break;
           case "LinearSingleKeyFrame":
               OnLinearSingleKeyFrame(xnode);
               break;
           case "LinearSizeKeyFrame":
               OnLinearSizeKeyFrame(xnode);
               break;
           case "LinearThicknessKeyFrame":
               OnLinearThicknessKeyFrame(xnode);
               break;
           case "LinearVector3DKeyFrame":
               OnLinearVector3DKeyFrame(xnode);
               break;
           case "LinearVectorKeyFrame":
               OnLinearVectorKeyFrame(xnode);
               break;
           case "LineBreak":
               OnLineBreak(xnode);
               break;
           case "LineGeometry":
               OnLineGeometry(xnode);
               break;
           case "LineSeement":
               OnLineSeement(xnode);
               break;
           case "List":
               OnList(xnode);
               break;
           case "ListBox":
               OnListBox(xnode);
               break;
           case "ListBoxAutomationPeer":
               OnListBoxAutomationPeer(xnode);
               break;
           case "ListBoxltem":
               OnListBoxltem(xnode);
               break;
           case "ListBoxItemAutomationPeer":
               OnListBoxItemAutomationPeer(xnode);
               break;
           case "ListBoxItemWrapperAutomationPecer":
               OnListBoxItemWrapperAutomationPecer(xnode);
               break;
           case "ListColectionView":
               OnListColectionView(xnode);
               break;
           case "ListItem":
               OnListItem(xnode);
               break;
           case "ListitemStructure":
               OnListitemStructure(xnode);
               break;
           case "ListStructure":
               OnListStructure(xnode);
               break;
           case "ListView":
               OnListView(xnode);
               break;
           case "ListViewAutomationPeer":
               OnListViewAutomationPeer(xnode);
               break;
           case "ListViewItem":
               OnListViewItem(xnode);
               break;
           case "LostFocusEventManager":
               OnLostFocusEventManager(xnode);
               break;
           case "ManipulationBoundaryFeedbackEvetArgs":
               OnManipulationBoundaryFeedbackEvetArgs(xnode);
               break;
           case "ManipulationCompletedEventArgs":
               OnManipulationCompletedEventArgs(xnode);
               break;
           case "ManipulationDeltaEventArgs":
               OnManipulationDeltaEventArgs(xnode);
               break;
           case "ManipulationInertiaStartingEventArgs":
               OnManipulationInertiaStartingEventArgs(xnode);
               break;
           case "ManipulationStartedEventArgs":
               OnManipulationStartedEventArgs(xnode);
               break;
           case "ManıpulationStartingErentArgs":
               OnManıpulationStartingErentArgs(xnode);
               break;
           case "MarkupExtension":
               OnMarkupExtension(xnode);
               break;
           case "Material":
               OnMaterial(xnode);
               break;
           case "MaterialCollection":
               OnMaterialCollection(xnode);
               break;
           case "MaterialGroup":
               OnMaterialGroup(xnode);
               break;
           case "Matrix3DValueSerializer":
               OnMatrix3DValueSerializer(xnode);
               break;
           case "MatrixAnimationBase":
               OnMatrixAnimationBase(xnode);
               break;
           case "MatrixAnimationUsingKeyFrames":
               OnMatrixAnimationUsingKeyFrames(xnode);
               break;
           case "MatrixAnimationUsingPath":
               OnMatrixAnimationUsingPath(xnode);
               break;
           case "MatrixCamera":
               OnMatrixCamera(xnode);
               break;
           case "MatrixKeyFrame":
               OnMatrixKeyFrame(xnode);
               break;
           case "MatrixKeyFrameCollection":
               OnMatrixKeyFrameCollection(xnode);
               break;
           case "MatrixTransform":
               OnMatrixTransform(xnode);
               break;
           case "MatrixTransform3D":
               OnMatrixTransform3D(xnode);
               break;
           case "MatrixValueSerializer":
               OnMatrixValueSerializer(xnode);
               break;
           case "MediaClock":
               OnMediaClock(xnode);
               break;
           case "MediaElement":
               OnMediaElement(xnode);
               break;
           case "MediaElementAutomationPeer":
               OnMediaElementAutomationPeer(xnode);
               break;
           case "MediaPlayer":
               OnMediaPlayer(xnode);
               break;
           case "MediaScriptCommandRoutedEventArgs":
               OnMediaScriptCommandRoutedEventArgs(xnode);
               break;
           case "MediaTimeline":
               OnMediaTimeline(xnode);
               break;
           case "MemberDefinition":
               OnMemberDefinition(xnode);
               break;
           case "Menu":
               OnMenu(xnode);
               break;
           case "MenuAutomationPeer":
               OnMenuAutomationPeer(xnode);
               break;
           case "MenuBase":
               OnMenuBase(xnode);
               break;
           case "MenuItem":
               OnMenuItem(xnode);
               break;
           case "MenuItemAutomationPeer":
               OnMenuItemAutomationPeer(xnode);
               break;
           case "MeshGeometry3D":
               OnMeshGeometry3D(xnode);
               break;
           case "Model3D":
               OnModel3D(xnode);
               break;
           case "Model3DCollection":
               OnModel3DCollection(xnode);
               break;
           case "Model3DGroup":
               OnModel3DGroup(xnode);
               break;
           case "ModelUIElement3D":
               OnModelUIElement3D(xnode);
               break;
           case "ModelVisual3D":
               OnModelVisual3D(xnode);
               break;
           case "ModifierKeysValueSerializer":
               OnModifierKeysValueSerializer(xnode);
               break;
           case "MouseActionValueSerializer":
               OnMouseActionValueSerializer(xnode);
               break;
           case "MouseBinding":
               OnMouseBinding(xnode);
               break;
           case "MouseButtonEventArgs":
               OnMouseButtonEventArgs(xnode);
               break;
           case "MouseDevice":
               OnMouseDevice(xnode);
               break;
           case "MouseDragElementBehavior":
               OnMouseDragElementBehavior(xnode);
               break;
           case "MouseEventArgs":
               OnMouseEventArgs(xnode);
               break;
           case "MouseGesture":
               OnMouseGesture(xnode);
               break;
           case "MouseGestureValueSerializer":
               OnMouseGestureValueSerializer(xnode);
               break;
           case "MouseWheelEventArgs":
               OnMouseWheelEventArgs(xnode);
               break;
           case "MultiBinding":
               OnMultiBinding(xnode);
               break;
           case "MultiBindingExpression":
               OnMultiBindingExpression(xnode);
               break;
           case "MultiDataTrigger":
               OnMultiDataTrigger(xnode);
               break;
           case "MultiSelector":
               OnMultiSelector(xnode);
               break;
           case "MultiTrigger":
               OnMultiTrigger(xnode);
               break;
           case "NamedElement":
               OnNamedElement(xnode);
               break;
           case "NavigationWindow":
               OnNavigationWindow(xnode);
               break;
           case "NavigationWindowAutomationPeer":
               OnNavigationWindowAutomationPeer(xnode);
               break;
           case "NotifyDataErrorValidationRule":
               OnNotifyDataErrorValidationRule(xnode);
               break;
           case "NotifyInputEventArgs":
               OnNotifyInputEventArgs(xnode);
               break;
           case "NullExtension":
               OnNullExtension(xnode);
               break;
           case "ObjectAnimationBase":
               OnObjectAnimationBase(xnode);
               break;
           case "ObjectAnimationUsingKeyFrames":
               OnObjectAnimationUsingKeyFrames(xnode);
               break;
           case "ObjectDataProvider":
               OnObjectDataProvider(xnode);
               break;
           case "ObjectKeyFrame":
               OnObjectKeyFrame(xnode);
               break;
           case "ObjectKeyFrameCollection":
               OnObjectKeyFrameCollection(xnode);
               break;
           case "OpenFileDialog":
               OnOpenFileDialog(xnode);
               break;
           case "OrthographicCamera":
               OnOrthographicCamera(xnode);
               break;
           case "OuterGlowBitmapEffect":
               OnOuterGlowBitmapEffect(xnode);
               break;
           case "Package":
               OnPackage(xnode);
               break;
           case "PackagePart":
               OnPackagePart(xnode);
               break;
           case "Page":
               OnPage(xnode);
               break;
           case "PageContent":
               OnPageContent(xnode);
               break;
           case "PageFunction":
               OnPageFunction(xnode);
               break;
           case "PageFunctionBase":
               OnPageFunctionBase(xnode);
               break;
           case "Panel":
               OnPanel(xnode);
               break;
           case "Paragraph":
               OnParagraph(xnode);
               break;
           case "ParagraphStructure":
               OnParagraphStructure(xnode);
               break;
           case "ParallelTimeline":
               OnParallelTimeline(xnode);
               break;
           case "PasswordBox":
               OnPasswordBox(xnode);
               break;
           case "PasswordBoxAutomationPeer":
               OnPasswordBoxAutomationPeer(xnode);
               break;
           case "Path":
               OnPath(xnode);
               break;
           case "PathFigure":
               OnPathFigure(xnode);
               break;
           case "PathFigureCollection":
               OnPathFigureCollection(xnode);
               break;
           case "PathFigureCollectionValueSenalizer":
               OnPathFigureCollectionValueSenalizer(xnode);
               break;
           case "PathGeometry":
               OnPathGeometry(xnode);
               break;
           case "PathSegment":
               OnPathSegment(xnode);
               break;
           case "PathSegmentCollection":
               OnPathSegmentCollection(xnode);
               break;
           case "PauseStoryboard":
               OnPauseStoryboard(xnode);
               break;
           case "Pen":
               OnPen(xnode);
               break;
           case "PerspectiveCamera":
               OnPerspectiveCamera(xnode);
               break;
           case "PixelShader":
               OnPixelShader(xnode);
               break;
           case "PlaySoundAction":
               OnPlaySoundAction(xnode);
               break;
           case "PngBitmapDecoder":
               OnPngBitmapDecoder(xnode);
               break;
           case "PngBitmapEncoder":
               OnPngBitmapEncoder(xnode);
               break;
           case "Point3DAnimation":
               OnPoint3DAnimation(xnode);
               break;
           case "Point3DAnimationBase":
               OnPoint3DAnimationBase(xnode);
               break;
           case "Point3DAnimationUsingKeyFrames":
               OnPoint3DAnimationUsingKeyFrames(xnode);
               break;
           case "Point3DCollection":
               OnPoint3DCollection(xnode);
               break;
           case "Point3DCollectionValueSerializer":
               OnPoint3DCollectionValueSerializer(xnode);
               break;
           case "Point3DKeyFrame":
               OnPoint3DKeyFrame(xnode);
               break;
           case "Point3DKeyFrameCollection":
               OnPoint3DKeyFrameCollection(xnode);
               break;
           case "Point3DValueSerializer":
               OnPoint3DValueSerializer(xnode);
               break;
           case "Point4DValueSerializer":
               OnPoint4DValueSerializer(xnode);
               break;
           case "PointAnimation":
               OnPointAnimation(xnode);
               break;
           case "PointAnimationBase":
               OnPointAnimationBase(xnode);
               break;
           case "PointAnimationUsingKeyFrames":
               OnPointAnimationUsingKeyFrames(xnode);
               break;
           case "PointAnimationUsingPath":
               OnPointAnimationUsingPath(xnode);
               break;
           case "PointCollection":
               OnPointCollection(xnode);
               break;
           case "PointCollectionValueSerializer":
               OnPointCollectionValueSerializer(xnode);
               break;
           case "PointHitTestParameters":
               OnPointHitTestParameters(xnode);
               break;
           case "PointHitTestResult":
               OnPointHitTestResult(xnode);
               break;
           case "PointIListConverter":
               OnPointIListConverter(xnode);
               break;
           case "PointKeyFrame":
               OnPointKeyFrame(xnode);
               break;
           case "PointKeyFrameCollection":
               OnPointKeyFrameCollection(xnode);
               break;
           case "PointLight":
               OnPointLight(xnode);
               break;
           case "PointLightBase":
               OnPointLightBase(xnode);
               break;
           case "PointValueSerializer":
               OnPointValueSerializer(xnode);
               break;
           case "PolyBezierSegment":
               OnPolyBezierSegment(xnode);
               break;
           case "Polygon":
               OnPolygon(xnode);
               break;
           case "Polylıne":
               OnPolylıne(xnode);
               break;
           case "PolyLineSegment":
               OnPolyLineSegment(xnode);
               break;
           case "PolyQuadraticBezierSegment":
               OnPolyQuadraticBezierSegment(xnode);
               break;
           case "Popup":
               OnPopup(xnode);
               break;
           case "PowerEase":
               OnPowerEase(xnode);
               break;
           case "PreProcessInputEventArgs":
               OnPreProcessInputEventArgs(xnode);
               break;
           case "PresentationSource":
               OnPresentationSource(xnode);
               break;
           case "PriorityBinding":
               OnPriorityBinding(xnode);
               break;
           case "PriorityBindingExpression":
               OnPriorityBindingExpression(xnode);
               break;
           case "ProcessInputEventArgs":
               OnProcessInputEventArgs(xnode);
               break;
           case "ProgressBar":
               OnProgressBar(xnode);
               break;
           case "ProgressBarAutomattonPeer":
               OnProgressBarAutomattonPeer(xnode);
               break;
           case "ProjectionCamera":
               OnProjectionCamera(xnode);
               break;
           case "PropertyChangedEventManager":
               OnPropertyChangedEventManager(xnode);
               break;
           case "PropertyChangedTrigger":
               OnPropertyChangedTrigger(xnode);
               break;
           case "PropertyDefinition":
               OnPropertyDefinition(xnode);
               break;
           case "PropertyGroupDescription":
               OnPropertyGroupDescription(xnode);
               break;
           case "PropertyMetadata":
               OnPropertyMetadata(xnode);
               break;
           case "QuadraticBezierSegment":
               OnQuadraticBezierSegment(xnode);
               break;
           case "OuadraticEase":
               OnOuadraticEase(xnode);
               break;
           case "QuarticEase":
               OnQuarticEase(xnode);
               break;
           case "QuaternionAnimation":
               OnQuaternionAnimation(xnode);
               break;
           case "QuaternionAnimationBase":
               OnQuaternionAnimationBase(xnode);
               break;
           case "QuaternionAnimationUsingKeyFrames":
               OnQuaternionAnimationUsingKeyFrames(xnode);
               break;
           case "QuaternionKeyFrame":
               OnQuaternionKeyFrame(xnode);
               break;
           case "QuaternionKeyFrameCollection":
               OnQuaternionKeyFrameCollection(xnode);
               break;
           case "QuaternionRotation3D":
               OnQuaternionRotation3D(xnode);
               break;
           case "QuaternionValueSerializer":
               OnQuaternionValueSerializer(xnode);
               break;
           case "QueryContinueDragEventArgs":
               OnQueryContinueDragEventArgs(xnode);
               break;
           case "QueryCursorEventArgs":
               OnQueryCursorEventArgs(xnode);
               break;
           case "QuinticEase":
               OnQuinticEase(xnode);
               break;
           case "RadialGradientBrush":
               OnRadialGradientBrush(xnode);
               break;
           case "RadioButton":
               OnRadioButton(xnode);
               break;
           case "RadioButtonAutomationPeer":
               OnRadioButtonAutomationPeer(xnode);
               break;
           case "RangeBase":
               OnRangeBase(xnode);
               break;
           case "RangeBaseAutomationPeer":
               OnRangeBaseAutomationPeer(xnode);
               break;
           case "RayHitTestParameters":
               OnRayHitTestParameters(xnode);
               break;
           case "RayHitTestResult":
               OnRayHitTestResult(xnode);
               break;
           case "RayMeshGeometry3DHitTestResult":
               OnRayMeshGeometry3DHitTestResult(xnode);
               break;
           case "Rect3DValueSerializer":
               OnRect3DValueSerializer(xnode);
               break;
           case "Rectangle":
               OnRectangle(xnode);
               break;
           case "RectangleGeometry":
               OnRectangleGeometry(xnode);
               break;
           case "RectangleStylusShape":
               OnRectangleStylusShape(xnode);
               break;
           case "RectAnimation":
               OnRectAnimation(xnode);
               break;
           case "RectAnimationBase":
               OnRectAnimationBase(xnode);
               break;
           case "RectAnimationUsingKeyFrames":
               OnRectAnimationUsingKeyFrames(xnode);
               break;
           case "RectKeyFrame":
               OnRectKeyFrame(xnode);
               break;
           case "RectKeyFrameCollection":
               OnRectKeyFrameCollection(xnode);
               break;
           case "RectValueSerializer":
               OnRectValueSerializer(xnode);
               break;
           case "Reference":
               OnReference(xnode);
               break;
           case "RelativeSource":
               OnRelativeSource(xnode);
               break;
           case "RemoveElementAction":
               OnRemoveElementAction(xnode);
               break;
           case "RemoveStoryboard":
               OnRemoveStoryboard(xnode);
               break;
           case "RenderTargetBitmap":
               OnRenderTargetBitmap(xnode);
               break;
           case "RepeteButton":
               OnRepeteButton(xnode);
               break;
           case "RepeatButtonAutomationPeer":
               OnRepeatButtonAutomationPeer(xnode);
               break;
           case "RequestBringIntoViewEventArgs":
               OnRequestBringIntoViewEventArgs(xnode);
               break;
           case "RequestNavigateEventArgs":
               OnRequestNavigateEventArgs(xnode);
               break;
           case "ResizeGrip":
               OnResizeGrip(xnode);
               break;
           case "ResourceKey":
               OnResourceKey(xnode);
               break;
           case "ResourceReferenceExpressionConverter":
               OnResourceReferenceExpressionConverter(xnode);
               break;
           case "ResumeStoryboard":
               OnResumeStoryboard(xnode);
               break;
           case "RichTextBox":
               OnRichTextBox(xnode);
               break;
           case "RichTextBoxAutomationPeer":
               OnRichTextBoxAutomationPeer(xnode);
               break;
           case "RotateTransform":
               OnRotateTransform(xnode);
               break;
           case "RotateTransform3D":
               OnRotateTransform3D(xnode);
               break;
           case "Rotation3D":
               OnRotation3D(xnode);
               break;
           case "Rotation3DAnimation":
               OnRotation3DAnimation(xnode);
               break;
           case "Rotation3DAnimationBase":
               OnRotation3DAnimationBase(xnode);
               break;
           case "Rotation3DAnimationUsingKeyFrames":
               OnRotation3DAnimationUsingKeyFrames(xnode);
               break;
           case "Rotation3DKeyFrame":
               OnRotation3DKeyFrame(xnode);
               break;
           case "Rotation3DKeyFrameCollection":
               OnRotation3DKeyFrameCollection(xnode);
               break;
           case "RoutedCommand":
               OnRoutedCommand(xnode);
               break;
           case "RoutedEventArgs":
               OnRoutedEventArgs(xnode);
               break;
           case "RoutedPropertyChangedEventArgs":
               OnRoutedPropertyChangedEventArgs(xnode);
               break;
           case "RoutedUICommand":
               OnRoutedUICommand(xnode);
               break;
           case "RowDefinition":
               OnRowDefinition(xnode);
               break;
           case "Run":
               OnRun(xnode);
               break;
           case "SaveFileDialog":
               OnSaveFileDialog(xnode);
               break;
           case "ScaleTransform":
               OnScaleTransform(xnode);
               break;
           case "ScaleTransform3D":
               OnScaleTransform3D(xnode);
               break;
           case "ScrollBar":
               OnScrollBar(xnode);
               break;
           case "ScrollBarAutomationPeer":
               OnScrollBarAutomationPeer(xnode);
               break;
           case "ScrollChangedEventArgs":
               OnScrollChangedEventArgs(xnode);
               break;
           case "ScrollContentPresenter":
               OnScrollContentPresenter(xnode);
               break;
           case "SerollEventArgs":
               OnSerollEventArgs(xnode);
               break;
           case "ScrollViewer":
               OnScrollViewer(xnode);
               break;
           case "ScrollViewerAutomationPeer":
               OnScrollViewerAutomationPeer(xnode);
               break;
           case "Section":
               OnSection(xnode);
               break;
           case "SectionStructure":
               OnSectionStructure(xnode);
               break;
           case "SeekStoryboard":
               OnSeekStoryboard(xnode);
               break;
           case "SelectionChangedEventArgs":
               OnSelectionChangedEventArgs(xnode);
               break;
           case "SelectiveScrollingGrid":
               OnSelectiveScrollingGrid(xnode);
               break;
           case "Selector":
               OnSelector(xnode);
               break;
           case "SelectorAutomationPeer":
               OnSelectorAutomationPeer(xnode);
               break;
           case "SelectorItemAutomationPeer":
               OnSelectorItemAutomationPeer(xnode);
               break;
           case "SemanticBasicElement":
               OnSemanticBasicElement(xnode);
               break;
           case "Separator":
               OnSeparator(xnode);
               break;
           case "SeparatorAutomationPeer":
               OnSeparatorAutomationPeer(xnode);
               break;
           case "ServiceProviders":
               OnServiceProviders(xnode);
               break;
           case "SetDataStoreValueAction":
               OnSetDataStoreValueAction(xnode);
               break;
           case "SetStoryboardSpeedRatio":
               OnSetStoryboardSpeedRatio(xnode);
               break;
           case "Setter":
               OnSetter(xnode);
               break;
           case "SetterBase":
               OnSetterBase(xnode);
               break;
           case "ShaderEfect":
               OnShaderEfect(xnode);
               break;
           case "Shape":
               OnShape(xnode);
               break;
           case "SineEase":
               OnSineEase(xnode);
               break;
           case "SingleAnimation":
               OnSingleAnimation(xnode);
               break;
           case "SingleAnimationBase":
               OnSingleAnimationBase(xnode);
               break;
           case "SingleAnimationUsingKeyFrames":
               OnSingleAnimationUsingKeyFrames(xnode);
               break;
           case "SingleKeyFrame":
               OnSingleKeyFrame(xnode);
               break;
           case "SingleKeyFrameCollection":
               OnSingleKeyFrameCollection(xnode);
               break;
           case "Size3DValueSerializer":
               OnSize3DValueSerializer(xnode);
               break;
           case "SizeAnimation":
               OnSizeAnimation(xnode);
               break;
           case "SizeAnimationBase":
               OnSizeAnimationBase(xnode);
               break;
           case "SizeAnimationUsingKeyFrames":
               OnSizeAnimationUsingKeyFrames(xnode);
               break;
           case "SizeChangedEventArgs":
               OnSizeChangedEventArgs(xnode);
               break;
           case "SizeKeyFrame":
               OnSizeKeyFrame(xnode);
               break;
           case "SizeKeyFrameCollection":
               OnSizeKeyFrameCollection(xnode);
               break;
           case "SizeValueSerializer":
               OnSizeValueSerializer(xnode);
               break;
           case "SkewTransform":
               OnSkewTransform(xnode);
               break;
           case "SkipStoryboardToFill":
               OnSkipStoryboardToFill(xnode);
               break;
           case "Slider":
               OnSlider(xnode);
               break;
           case "SiderAutomationPeer":
               OnSiderAutomationPeer(xnode);
               break;
           case "SolidColorBrush":
               OnSolidColorBrush(xnode);
               break;
           case "SoundPlayerAction":
               OnSoundPlayerAction(xnode);
               break;
           case "SourceChangedEventArgs":
               OnSourceChangedEventArgs(xnode);
               break;
           case "Span":
               OnSpan(xnode);
               break;
           case "SpecularMaterial":
               OnSpecularMaterial(xnode);
               break;
           case "SplineByteKeyFrame":
               OnSplineByteKeyFrame(xnode);
               break;
           case "SplıneColorKeyFrame":
               OnSplıneColorKeyFrame(xnode);
               break;
           case "SplineDecimalKeyFrame":
               OnSplineDecimalKeyFrame(xnode);
               break;
           case "SplineDoubleKeyFrame":
               OnSplineDoubleKeyFrame(xnode);
               break;
           case "Splinelnt16KeyFrame":
               OnSplinelnt16KeyFrame(xnode);
               break;
           case "Splinelnt32KeyFrame":
               OnSplinelnt32KeyFrame(xnode);
               break;
           case "Splinelnt64KeyFrame":
               OnSplinelnt64KeyFrame(xnode);
               break;
           case "SplinePoint3DKeyFrame":
               OnSplinePoint3DKeyFrame(xnode);
               break;
           case "SplinePointKevFrame":
               OnSplinePointKevFrame(xnode);
               break;
           case "SplineQuaternionKeyFrame":
               OnSplineQuaternionKeyFrame(xnode);
               break;
           case "SplineRectKeyFrame":
               OnSplineRectKeyFrame(xnode);
               break;
           case "SplineRotation3DKeyFrame":
               OnSplineRotation3DKeyFrame(xnode);
               break;
           case "SplineSingleKeyFrame":
               OnSplineSingleKeyFrame(xnode);
               break;
           case "SplineSizeKeyFrame":
               OnSplineSizeKeyFrame(xnode);
               break;
           case "SplineThicknessKeyFrame":
               OnSplineThicknessKeyFrame(xnode);
               break;
           case "SplineVector3DKeyFrame":
               OnSplineVector3DKeyFrame(xnode);
               break;
           case "SplineVectorKeyFrame":
               OnSplineVectorKeyFrame(xnode);
               break;
           case "SpotLight":
               OnSpotLight(xnode);
               break;
           case "StackPanel":
               OnStackPanel(xnode);
               break;
           case "StaticExtension":
               OnStaticExtension(xnode);
               break;
           case "StaticResourceExtension":
               OnStaticResourceExtension(xnode);
               break;
           case "StatusBar":
               OnStatusBar(xnode);
               break;
           case "StatusBarAutomationPeer":
               OnStatusBarAutomationPeer(xnode);
               break;
           case "StatusBarItem":
               OnStatusBarItem(xnode);
               break;
           case "StatusBarItemAutomationPeer":
               OnStatusBarItemAutomationPeer(xnode);
               break;
           case "StickyNoteControl":
               OnStickyNoteControl(xnode);
               break;
           case "StopStoryboard":
               OnStopStoryboard(xnode);
               break;
           case "Storyboard":
               OnStoryboard(xnode);
               break;
           case "StoryboardAction":
               OnStoryboardAction(xnode);
               break;
           case "StoryboardCompletedTrigger":
               OnStoryboardCompletedTrigger(xnode);
               break;
           case "StoryboardTrigger":
               OnStoryboardTrigger(xnode);
               break;
           case "StoryBreak":
               OnStoryBreak(xnode);
               break;
           case "StreamGeometry":
               OnStreamGeometry(xnode);
               break;
           case "StreamGeometryContext":
               OnStreamGeometryContext(xnode);
               break;
           case "StringAnimationBase":
               OnStringAnimationBase(xnode);
               break;
           case "StringAnimationUsingKevFrames":
               OnStringAnimationUsingKevFrames(xnode);
               break;
           case "StringKeyFrame":
               OnStringKeyFrame(xnode);
               break;
           case "StringKeyFrameCollection":
               OnStringKeyFrameCollection(xnode);
               break;
           case "Style":
               OnStyle(xnode);
               break;
           case "StylusButtonEventArgs":
               OnStylusButtonEventArgs(xnode);
               break;
           case "StylusDevice":
               OnStylusDevice(xnode);
               break;
           case "StylusDownEventArgs":
               OnStylusDownEventArgs(xnode);
               break;
           case "StylusPlugIn":
               OnStylusPlugIn(xnode);
               break;
           case "StylusEventArgs":
               OnStylusEventArgs(xnode);
               break;
           case "StylusPontProperty":
               OnStylusPontProperty(xnode);
               break;
           case "StylusPointPropertyInfo":
               OnStylusPointPropertyInfo(xnode);
               break;
           case "StylusShape":
               OnStylusShape(xnode);
               break;
           case "StylusSystemGestureEventArgs":
               OnStylusSystemGestureEventArgs(xnode);
               break;
           case "TabControl":
               OnTabControl(xnode);
               break;
           case "TabControlAutomationPeer":
               OnTabControlAutomationPeer(xnode);
               break;
           case "TabItern":
               OnTabItern(xnode);
               break;
           case "TabItenAutomationPeer":
               OnTabItenAutomationPeer(xnode);
               break;
           case "TabItemWrapperAutomationPeer":
               OnTabItemWrapperAutomationPeer(xnode);
               break;
           case "Table":
               OnTable(xnode);
               break;
           case "TableAutomationPeer":
               OnTableAutomationPeer(xnode);
               break;
           case "TableCell":
               OnTableCell(xnode);
               break;
           case "TableCellAutomationPeer":
               OnTableCellAutomationPeer(xnode);
               break;
           case "TableCellStructure":
               OnTableCellStructure(xnode);
               break;
           case "TableColumn":
               OnTableColumn(xnode);
               break;
           case "TableRow":
               OnTableRow(xnode);
               break;
           case "TableRowGroup":
               OnTableRowGroup(xnode);
               break;
           case "TableRowGroupStructure":
               OnTableRowGroupStructure(xnode);
               break;
           case "TableRowStructure":
               OnTableRowStructure(xnode);
               break;
           case "TableStructure":
               OnTableStructure(xnode);
               break;
           case "TabletDevice":
               OnTabletDevice(xnode);
               break;
           case "TabPanel":
               OnTabPanel(xnode);
               break;
           case "TargetedTriggerAction":
               OnTargetedTriggerAction(xnode);
               break;
           case "TaskbarltemInfo":
               OnTaskbarltemInfo(xnode);
               break;
           case "TemplateBindingExpression":
               OnTemplateBindingExpression(xnode);
               break;
           case "TemplateBindingExtension":
               OnTemplateBindingExtension(xnode);
               break;
           case "TemplateContentLoader":
               OnTemplateContentLoader(xnode);
               break;
           case "TemplateKey":
               OnTemplateKey(xnode);
               break;
           case "TextAutomationPeer":
               OnTextAutomationPeer(xnode);
               break;
           case "TextBlock":
               OnTextBlock(xnode);
               break;
           case "TextBlockAutomationPeer":
               OnTextBlockAutomationPeer(xnode);
               break;
           case "TextBox":
               OnTextBox(xnode);
               break;
           case "TextBoxAutomationPeer":
               OnTextBoxAutomationPeer(xnode);
               break;
           case "TextBoxBase":
               OnTextBoxBase(xnode);
               break;
           case "TextChangedEventArgs":
               OnTextChangedEventArgs(xnode);
               break;
           case "TextCharacters":
               OnTextCharacters(xnode);
               break;
           case "TextCollapsingProperties":
               OnTextCollapsingProperties(xnode);
               break;
           case "TextComposıtion":
               OnTextComposıtion(xnode);
               break;
           case "TextCompositionEventArgs":
               OnTextCompositionEventArgs(xnode);
               break;
           case "TextCompositionManager":
               OnTextCompositionManager(xnode);
               break;
           case "TextDecoration":
               OnTextDecoration(xnode);
               break;
           case "TextDecorationCollection":
               OnTextDecorationCollection(xnode);
               break;
           case "TextEffect":
               OnTextEffect(xnode);
               break;
           case "TextEftectCollection":
               OnTextEftectCollection(xnode);
               break;
           case "TextElement":
               OnTextElement(xnode);
               break;
           case "TextElementAutomationPeer":
               OnTextElementAutomationPeer(xnode);
               break;
           case "TextEmbeddedObject":
               OnTextEmbeddedObject(xnode);
               break;
           case "TextEndOfLine":
               OnTextEndOfLine(xnode);
               break;
           case "TextEndOfParagraph":
               OnTextEndOfParagraph(xnode);
               break;
           case "TextEndOfSegment":
               OnTextEndOfSegment(xnode);
               break;
           case "TextHidden":
               OnTextHidden(xnode);
               break;
           case "TextMarkerProperties":
               OnTextMarkerProperties(xnode);
               break;
           case "TextModifier":
               OnTextModifier(xnode);
               break;
           case "TextPointer":
               OnTextPointer(xnode);
               break;
           case "TextRange":
               OnTextRange(xnode);
               break;
           case "TextRun":
               OnTextRun(xnode);
               break;
           case "TextSearch":
               OnTextSearch(xnode);
               break;
           case "TextSelection":
               OnTextSelection(xnode);
               break;
           case "TextSimpleMarkerProperties":
               OnTextSimpleMarkerProperties(xnode);
               break;
           case "TextTrailingCharacterEllipsis":
               OnTextTrailingCharacterEllipsis(xnode);
               break;
           case "TextTrailingWordEllipsis":
               OnTextTrailingWordEllipsis(xnode);
               break;
           case "ThemeDictionaryExtension":
               OnThemeDictionaryExtension(xnode);
               break;
           case "ThicknessAnimation":
               OnThicknessAnimation(xnode);
               break;
           case "ThicknessAnimationBase":
               OnThicknessAnimationBase(xnode);
               break;
           case "ThicknessAnimationUsingKeyFrames":
               OnThicknessAnimationUsingKeyFrames(xnode);
               break;
           case "ThicknessKeyFrame":
               OnThicknessKeyFrame(xnode);
               break;
           case "ThicknessKeyFrameCollection":
               OnThicknessKeyFrameCollection(xnode);
               break;
           case "Thumb":
               OnThumb(xnode);
               break;
           case "ThumbAutomationPeer":
               OnThumbAutomationPeer(xnode);
               break;
           case "ThumbButonInfo":
               OnThumbButonInfo(xnode);
               break;
           case "ThumbButtonlnfoCollection":
               OnThumbButtonlnfoCollection(xnode);
               break;
           case "TickBar":
               OnTickBar(xnode);
               break;
           case "TiffBitmap":
               OnTiffBitmap(xnode);
               break;
           case "TiffBitmapEncoder":
               OnTiffBitmapEncoder(xnode);
               break;
           case "TileBrush":
               OnTileBrush(xnode);
               break;
           case "Timeline":
               OnTimeline(xnode);
               break;
           case "TimelineCollection":
               OnTimelineCollection(xnode);
               break;
           case "TimelıneGroup":
               OnTimelıneGroup(xnode);
               break;
           case "TimerTrigger":
               OnTimerTrigger(xnode);
               break;
           case "ToggleButton":
               OnToggleButton(xnode);
               break;
           case "ToggleButtonAutomationPeer":
               OnToggleButtonAutomationPeer(xnode);
               break;
           case "ToolBar":
               OnToolBar(xnode);
               break;
           case "TooIBarAutomationPeer":
               OnTooIBarAutomationPeer(xnode);
               break;
           case "ToolBarOverflowPanel":
               OnToolBarOverflowPanel(xnode);
               break;
           case "ToolBarPanel":
               OnToolBarPanel(xnode);
               break;
           case "ToolBarTray":
               OnToolBarTray(xnode);
               break;
           case "ToolTip":
               OnToolTip(xnode);
               break;
           case "ToolTipAutomationPeer":
               OnToolTipAutomationPeer(xnode);
               break;
           case "ToolTipEventArg3G":
               OnToolTipEventArg3G(xnode);
               break;
           case "TouchDevice":
               OnTouchDevice(xnode);
               break;
           case "TouchDeviceArgs":
               OnTouchDeviceArgs(xnode);
               break;
           case "Track":
               OnTrack(xnode);
               break;
           case "Transform":
               OnTransform(xnode);
               break;
           case "Transform3D":
               OnTransform3D(xnode);
               break;
           case "Transformn3DCollection":
               OnTransformn3DCollection(xnode);
               break;
           case "Transform3DGroup":
               OnTransform3DGroup(xnode);
               break;
           case "TransformCollection":
               OnTransformCollection(xnode);
               break;
           case "TransformedBitmap":
               OnTransformedBitmap(xnode);
               break;
           case "TransformGroup":
               OnTransformGroup(xnode);
               break;
           case "TransformValueSerializer":
               OnTransformValueSerializer(xnode);
               break;
           case "TransitionEfect":
               OnTransitionEfect(xnode);
               break;
           case "TranslateTransform":
               OnTranslateTransform(xnode);
               break;
           case "TranslateTransfom3D":
               OnTranslateTransfom3D(xnode);
               break;
           case "TranslateZoomRotateBehavior":
               OnTranslateZoomRotateBehavior(xnode);
               break;
           case "TreeView":
               OnTreeView(xnode);
               break;
           case "TreeViewAutomationPeer":
               OnTreeViewAutomationPeer(xnode);
               break;
           case "TreeViewDataltemAutomationPeer":
               OnTreeViewDataltemAutomationPeer(xnode);
               break;
           case "TreeViewItem":
               OnTreeViewItem(xnode);
               break;
           case "TreeViewItemAutomationPeer":
               OnTreeViewItemAutomationPeer(xnode);
               break;
           case "Trigger":
               OnTrigger(xnode);
               break;
           case "TriggerAction":
               OnTriggerAction(xnode);
               break;
           case "TriggerActionCollection":
               OnTriggerActionCollection(xnode);
               break;
           case "TriggerBase":
               OnTriggerBase(xnode);
               break;
           case "TriggerCollection":
               OnTriggerCollection(xnode);
               break;
           case "TypeConverter":
               OnTypeConverter(xnode);
               break;
           case "TypeExtension":
               OnTypeExtension(xnode);
               break;
           case "UIElement":
               OnUIElement(xnode);
               break;
           case "UElement3D":
               OnUElement3D(xnode);
               break;
           case "UIElement3DAutomationPeer":
               OnUIElement3DAutomationPeer(xnode);
               break;
           case "UIElementAutomationPeer":
               OnUIElementAutomationPeer(xnode);
               break;
           case "UIPropertyMetadata":
               OnUIPropertyMetadata(xnode);
               break;
           case "Underline":
               OnUnderline(xnode);
               break;
           case "UniformGrid":
               OnUniformGrid(xnode);
               break;
           case "UserControl":
               OnUserControl(xnode);
               break;
           case "UserControlAutomationPeer":
               OnUserControlAutomationPeer(xnode);
               break;
           case "UShortlListConverter":
               OnUShortlListConverter(xnode);
               break;
           case "ValidationErrorEventArgs":
               OnValidationErrorEventArgs(xnode);
               break;
           case "ValidationRule":
               OnValidationRule(xnode);
               break;
           case "ValueSerializer":
               OnValueSerializer(xnode);
               break;
           case "Vector3DAnimation":
               OnVector3DAnimation(xnode);
               break;
           case "Vector3DAnimationBase":
               OnVector3DAnimationBase(xnode);
               break;
           case "Vector3DAnimationUsingKeyFrames":
               OnVector3DAnimationUsingKeyFrames(xnode);
               break;
           case "Vector3DCollection":
               OnVector3DCollection(xnode);
               break;
           case "Vector3DCollectionValueSerializer":
               OnVector3DCollectionValueSerializer(xnode);
               break;
           case "Vector3DKeyFrame":
               OnVector3DKeyFrame(xnode);
               break;
           case "Vector3DKevFrameCollection":
               OnVector3DKevFrameCollection(xnode);
               break;
           case "Vector3DValueSerializer":
               OnVector3DValueSerializer(xnode);
               break;
           case "VectorAnimation":
               OnVectorAnimation(xnode);
               break;
           case "VectorAnimationBase":
               OnVectorAnimationBase(xnode);
               break;
           case "VectorAnimationUsingKeyFrames":
               OnVectorAnimationUsingKeyFrames(xnode);
               break;
           case "VectorCollection":
               OnVectorCollection(xnode);
               break;
           case "VectorCollectionValueSerializer":
               OnVectorCollectionValueSerializer(xnode);
               break;
           case "VectorKeyFrame":
               OnVectorKeyFrame(xnode);
               break;
           case "VectorKeyFrameCollection":
               OnVectorKeyFrameCollection(xnode);
               break;
           case "VectorValueSerializer":
               OnVectorValueSerializer(xnode);
               break;
           case "VideoDrawing":
               OnVideoDrawing(xnode);
               break;
           case "ViewBase":
               OnViewBase(xnode);
               break;
           case "Viewbox":
               OnViewbox(xnode);
               break;
           case "Viewport2DVisual3D":
               OnViewport2DVisual3D(xnode);
               break;
           case "Viewport3D":
               OnViewport3D(xnode);
               break;
           case "Viewport3DAutomationPeer":
               OnViewport3DAutomationPeer(xnode);
               break;
           case "Viewport3DVisual":
               OnViewport3DVisual(xnode);
               break;
           case "VrtualizingPanel":
               OnVrtualizingPanel(xnode);
               break;
           case "VtualizingStackPanel":
               OnVtualizingStackPanel(xnode);
               break;
           case "Visual":
               OnVisual(xnode);
               break;
           case "Visual3D":
               OnVisual3D(xnode);
               break;
           case "VisualBrush":
               OnVisualBrush(xnode);
               break;
           case "VisualState":
               OnVisualState(xnode);
               break;
           case "VisualStateGroup":
               OnVisualStateGroup(xnode);
               break;
           case "VisualStateManager":
               OnVisualStateManager(xnode);
               break;
           case "VisualTarget":
               OnVisualTarget(xnode);
               break;
           case "VisualTransition":
               OnVisualTransition(xnode);
               break;
           case "WeakEventManager":
               OnWeakEventManager(xnode);
               break;
           case "WebBrowser":
               OnWebBrowser(xnode);
               break;
           case "Window":
               OnWindow(xnode);
               break;
           case "WindowAutomationPeer":
               OnWindowAutomationPeer(xnode);
               break;
           case "WindowChrome":
               OnWindowChrome(xnode);
               break;
           case "WmpBitmapDecoder":
               OnWmpBitmapDecoder(xnode);
               break;
           case "WmpBitmapEncoder":
               OnWmpBitmapEncoder(xnode);
               break;
           case "WrapPanel":
               OnWrapPanel(xnode);
               break;
           case "WriteableBitmap":
               OnWriteableBitmap(xnode);
               break;
           case "XamlBackgroundReader":
               OnXamlBackgroundReader(xnode);
               break;
           case "XamlDeferringLoader":
               OnXamlDeferringLoader(xnode);
               break;
           case "XamlDesignerSernalizationManager":
               OnXamlDesignerSernalizationManager(xnode);
               break;
           case "XamlDirective":
               OnXamlDirective(xnode);
               break;
           case "XamlDuplicateMemberException":
               OnXamlDuplicateMemberException(xnode);
               break;
           case "XamlException":
               OnXamlException(xnode);
               break;
           case "XamlInternalException":
               OnXamlInternalException(xnode);
               break;
           case "XamlMember":
               OnXamlMember(xnode);
               break;
           case "XamlObjectReader":
               OnXamlObjectReader(xnode);
               break;
           case "XamlObjectReaderException":
               OnXamlObjectReaderException(xnode);
               break;
           case "XamlObjectReaderSettings":
               OnXamlObjectReaderSettings(xnode);
               break;
           case "XamlObjectWriter":
               OnXamlObjectWriter(xnode);
               break;
           case "XamlObjectWriterException":
               OnXamlObjectWriterException(xnode);
               break;
           case "XamlObjectWriterSettings":
               OnXamlObjectWriterSettings(xnode);
               break;
           case "XamlParseException":
               OnXamlParseException(xnode);
               break;
           case "XamlReader":
               OnXamlReader(xnode);
               break;
           case "XamlReaderSettings":
               OnXamlReaderSettings(xnode);
               break;
           case "XamlSchemaException":
               OnXamlSchemaException(xnode);
               break;
           case "XamlSetMarkupExtensionEventArgs":
               OnXamlSetMarkupExtensionEventArgs(xnode);
               break;
           case "XamlSetypeConverterEventArgs":
               OnXamlSetypeConverterEventArgs(xnode);
               break;
           case "XamSetValueEentArgs":
               OnXamSetValueEentArgs(xnode);
               break;
           case "XamlWriter":
               OnXamlWriter(xnode);
               break;
           case "XamlWriterSettings":
               OnXamlWriterSettings(xnode);
               break;
           case "XamlXmlReader":
               OnXamlXmlReader(xnode);
               break;
           case "XamlXmlReaderSettings":
               OnXamlXmlReaderSettings(xnode);
               break;
           case "XamlXmlWriter":
               OnXamlXmlWriter(xnode);
               break;
           case "XamlXmlWriterException":
               OnXamlXmlWriterException(xnode);
               break;
           case "XamlXmlWriterSettings":
               OnXamlXmlWriterSettings(xnode);
               break;
           case "XmlDataProvider":
               OnXmlDataProvider(xnode);
               break;
           case "XmlStreamStore":
               OnXmlStreamStore(xnode);
               break;
           case "ZipPackage":
               OnZipPackage(xnode);
               break;
           case "ZipPackagePart":
               OnZipPackagePart(xnode);
               break;
           //
           default:
               OnDefaultNode(xnode);
               break;
       }
   }

   public virtual void OnAccessKeyPressedEventArgs(XXmlNode xnode) {}
   public virtual void OnAccessText(XXmlNode xnode) {}
   public virtual void OnActiveXHost(XXmlNode xnode) {}
   public virtual void OnAdormedElementPlaceholder(XXmlNode xnode) {}
   public virtual void OnAdorner(XXmlNode xnode) {}
   public virtual void OnAdornerContainer(XXmlNode xnode) {}
   public virtual void OnAdornerDecorator(XXmlNode xnode) {}
   public virtual void OnAdornerHitTestResut(XXmlNode xnode) {}
   public virtual void OnAdornerLayer(XXmlNode xnode) {}
   public virtual void OnAffineTransform3D(XXmlNode xnode) {}
   public virtual void OnAmbientLight(XXmlNode xnode) {}
   public virtual void OnAnchoredBlock(XXmlNode xnode) {}
   public virtual void OnAnimatable(XXmlNode xnode) {}
   public virtual void OnAnimationClock(XXmlNode xnode) {}
   public virtual void OnAnimationTimeline(XXmlNode xnode) {}
   public virtual void OnAnnotationDocumemtPagnator(XXmlNode xnode) {}
   public virtual void OnAnnotationService(XXmlNode xnode) {}
   public virtual void OnAnnotationStore(XXmlNode xnode) {}
   public virtual void OnApplication(XXmlNode xnode) {}
   public virtual void OnArcSegment(XXmlNode xnode) {}
   public virtual void OnArrayExtension(XXmlNode xnode) {}
   public virtual void OnAttachableCollection(XXmlNode xnode) {}
   public virtual void OnAttachedPropertyBrowsableAttibute(XXmlNode xnode) {}
   public virtual void OnAttachedPropertyBrowsableForChildrenAttribute(XXmlNode xnode) {}
   public virtual void OnAttachedPropertyBrowsableForTypeAttribute(XXmlNode xnode) {}
   public virtual void OnAttachedPropertyBrowsableWhenAttributePresentAttribute(XXmlNode xnode) {}
   public virtual void OnAttribute(XXmlNode xnode) {}
   public virtual void OnAutomationPeer(XXmlNode xnode) {}
   public virtual void OnAxisAngleRotation3D(XXmlNode xnode) {}
   public virtual void OnBackEase(XXmlNode xnode) {}
   public virtual void OnBaml2006Reader(XXmlNode xnode) {}
   public virtual void OnBaseIListConverter(XXmlNode xnode) {}
   public virtual void OnBeginStoryboard(XXmlNode xnode) {}
   public virtual void OnBehavior(XXmlNode xnode) {}
   public virtual void OnBehaviorCollection(XXmlNode xnode) {}
   public virtual void OnBevelBitmapEffect(XXmlNode xnode) {}
   public virtual void OnBezierSegment(XXmlNode xnode) {}
   public virtual void OnBinding(XXmlNode xnode) {}
   public virtual void OnBindingBase(XXmlNode xnode) {}
   public virtual void OnBindingExpression(XXmlNode xnode) {}
   public virtual void OnBindingExpressionBase(XXmlNode xnode) {}
   public virtual void OnBindingGroup(XXmlNode xnode) {}
   public virtual void OnBindingListCollectionView(XXmlNode xnode) {}
   public virtual void OnBitmapCache(XXmlNode xnode) {}
   public virtual void OnBitmapCacheBrush(XXmlNode xnode) {}
   public virtual void OnBitmapDecoder(XXmlNode xnode) {}
   public virtual void OnBitmapEffect(XXmlNode xnode) {}
   public virtual void OnBitmapEffectCollection(XXmlNode xnode) {}
   public virtual void OnBitmapEffectGroup(XXmlNode xnode) {}
   public virtual void OnBitmapEffectInput(XXmlNode xnode) {}
   public virtual void OnBitmapEncoder(XXmlNode xnode) {}
   public virtual void OnBitmapFrame(XXmlNode xnode) {}
   public virtual void OnBitmapImage(XXmlNode xnode) {}
   public virtual void OnBitmapMetadata(XXmlNode xnode) {}
   public virtual void OnBitmapPalette(XXmlNode xnode) {}
   public virtual void OnBitmapSource(XXmlNode xnode) {}
   public virtual void OnBlock(XXmlNode xnode) {}
   public virtual void OnBlockElement(XXmlNode xnode) {}
   public virtual void OnBlockUIContainer(XXmlNode xnode) {}
   public virtual void OnBlurBitmapEffect(XXmlNode xnode) {}
   public virtual void OnBlurEffect(XXmlNode xnode) {}
   public virtual void OnBmpBitmapDecoder(XXmlNode xnode) {}
   public virtual void OnBmpBitmapEncoder(XXmlNode xnode) {}
   public virtual void OnBold(XXmlNode xnode) {}
   public virtual void OnBooleanAnimationBase(XXmlNode xnode) {}
   public virtual void OnBooleanAnimationUsingKeyFrames(XXmlNode xnode) {}
   public virtual void OnBooleanKeyFrame(XXmlNode xnode) {}
   public virtual void OnBooleanKeyFrameCollection(XXmlNode xnode) {}
   public virtual void OnBoolIListConverter(XXmlNode xnode) {}
   public virtual void OnBorder(XXmlNode xnode) {}
   public virtual void OnBounceEase(XXmlNode xnode) {}
   public virtual void OnBrush(XXmlNode xnode) {}
   public virtual void OnBrushValueSerializer(XXmlNode xnode) {}
   public virtual void OnBulletDecorator(XXmlNode xnode) {}
   public virtual void OnButton(XXmlNode xnode) {}
   public virtual void OnButtonAutomationPeer(XXmlNode xnode) {}
   public virtual void OnButtonBase(XXmlNode xnode) {}
   public virtual void OnButtonBaseAutomationPeer(XXmlNode xnode) {}
   public virtual void OnByteAnimation(XXmlNode xnode) {}
   public virtual void OnByteAnimationBase(XXmlNode xnode) {}
   public virtual void OnByteAnimationUsingKeyFrames(XXmlNode xnode) {}
   public virtual void OnByteKeyFrame(XXmlNode xnode) {}
   public virtual void OnBytekeyFrameCollection(XXmlNode xnode) {}
   public virtual void OnCachedBitmap(XXmlNode xnode) {}
   public virtual void OnCacheMode(XXmlNode xnode) {}
   public virtual void OnCacheModeValueSerializer(XXmlNode xnode) {}
   public virtual void OnCalendar(XXmlNode xnode) {}
   public virtual void OnCalendarAutomationPeer(XXmlNode xnode) {}
   public virtual void OnCalendarButton(XXmlNode xnode) {}
   public virtual void OnCalendarButtonAutomationPeer(XXmlNode xnode) {}
   public virtual void OnCalendarDateChangedEventArgs(XXmlNode xnode) {}
   public virtual void OnCalendarDayButton(XXmlNode xnode) {}
   public virtual void OnCalendarltem(XXmlNode xnode) {}
   public virtual void OnCalendarModeChangedEventArgs(XXmlNode xnode) {}
   public virtual void OnCallMethodAction(XXmlNode xnode) {}
   public virtual void OnCamera(XXmlNode xnode) {}
   public virtual void OnCanExecuteChangedEventManager(XXmlNode xnode) {}
   public virtual void OnCanExecuteRoutedEventArgs(XXmlNode xnode) {}
   public virtual void OnCanvas(XXmlNode xnode) {}
   public virtual void OnChangePropertyAction(XXmlNode xnode) {}
   public virtual void OnCharAnimationBase(XXmlNode xnode) {}
   public virtual void OnCharAnimationUsingKeyFrame(XXmlNode xnode) {}
   public virtual void OnCharIListConverter(XXmlNode xnode) {}
   public virtual void OnCharKeyFrame(XXmlNode xnode) {}
   public virtual void OnCharKeyFrameCollection(XXmlNode xnode) {}
   public virtual void OnCheckBox(XXmlNode xnode) {}
   public virtual void OnCheckBoxAutomationPeer(XXmlNode xnode) {}
   public virtual void OnCircleEase(XXmlNode xnode) {}
   public virtual void OnCleanUpVirtualizedItemEventArgs(XXmlNode xnode) {}
   public virtual void OnClock(XXmlNode xnode) {}
   public virtual void OnClockController(XXmlNode xnode) {}
   public virtual void OnClockGroup(XXmlNode xnode) {}
   public virtual void OnCollectionChangedEventManager(XXmlNode xnode) {}
   public virtual void OnCollectionContainer(XXmlNode xnode) {}
   public virtual void OnCollectionView(XXmlNode xnode) {}
   public virtual void OnCollectionViewSource(XXmlNode xnode) {}
   public virtual void OnColorAnimation(XXmlNode xnode) {}
   public virtual void OnColorAnimationBase(XXmlNode xnode) {}
   public virtual void OnColorAnimationUsingKeyFrames(XXmlNode xnode) {}
   public virtual void OnColorConvertedBitmap(XXmlNode xnode) {}
   public virtual void OnColorConvertedBitmapExtension(XXmlNode xnode) {}
   public virtual void OnColorKeyFrame(XXmlNode xnode) {}
   public virtual void OnColorKeyFrameCollection(XXmlNode xnode) {}
   public virtual void OnColorDefinition(XXmlNode xnode) {}
   public virtual void OnCombinedGeometry(XXmlNode xnode) {}
   public virtual void OnComboBox(XXmlNode xnode) {}
   public virtual void OnComboBoxAutomationPeer(XXmlNode xnode) {}
   public virtual void OnComboBoxltem(XXmlNode xnode) {}
   public virtual void OnCommonDialog(XXmlNode xnode) {}
   public virtual void OnComparisonCondition(XXmlNode xnode) {}
   public virtual void OnComponentResourceKey(XXmlNode xnode) {}
   public virtual void OnComponentResourceKeyConverter(XXmlNode xnode) {}
   public virtual void OnCompositionTarget(XXmlNode xnode) {}
   public virtual void OnConditionalExpression(XXmlNode xnode) {}
   public virtual void OnConditionBehavior(XXmlNode xnode) {}
   public virtual void OnConditionCollection(XXmlNode xnode) {}
   public virtual void OnContainerUIElement3D(XXmlNode xnode) {}
   public virtual void OnContainerVisual(XXmlNode xnode) {}
   public virtual void OnContentControl(XXmlNode xnode) {}
   public virtual void OnContentElement(XXmlNode xnode) {}
   public virtual void OnContentElementAutomationPeer(XXmlNode xnode) {}
   public virtual void OnContentLocator(XXmlNode xnode) {}
   public virtual void OnContentocatorBase(XXmlNode xnode) {}
   public virtual void OnContentLocatorGroup(XXmlNode xnode) {}
   public virtual void OnContentPosition(XXmlNode xnode) {}
   public virtual void OnContentPresenter(XXmlNode xnode) {}
   public virtual void OnContentTextAutomationPeer(XXmlNode xnode) {}
   public virtual void OnContextMenu(XXmlNode xnode) {}
   public virtual void OnContextMenuAutomationPeer(XXmlNode xnode) {}
   public virtual void OnContextMenuEventArgs(XXmlNode xnode) {}
   public virtual void OnControl(XXmlNode xnode) {}
   public virtual void OnControllableStoryboardAction(XXmlNode xnode) {}
   public virtual void OnControlStoryboardAction(XXmlNode xnode) {}
   public virtual void OnControlTemplate(XXmlNode xnode) {}
   public virtual void OnCroppedBitmap(XXmlNode xnode) {}
   public virtual void OnCubicEase(XXmlNode xnode) {}
   public virtual void OnCurrentChangedEventManager(XXmlNode xnode) {}
   public virtual void OnCurrentChangingEventManager(XXmlNode xnode) {}
   public virtual void OnD3DImage(XXmlNode xnode) {}
   public virtual void OnDashStyle(XXmlNode xnode) {}
   public virtual void OnDataChangedEventManager(XXmlNode xnode) {}
   public virtual void OnDataErrorValidationRule(XXmlNode xnode) {}
   public virtual void OnDataGrid(XXmlNode xnode) {}
   public virtual void OnDataGridAutomationPeer(XXmlNode xnode) {}
   public virtual void OnDataGridBoundColumn(XXmlNode xnode) {}
   public virtual void OnDataGridCell(XXmlNode xnode) {}
   public virtual void OnDataGridCellAutomationPeer(XXmlNode xnode) {}
   public virtual void OnDataGridCellItemAutomationPeer(XXmlNode xnode) {}
   public virtual void OnDataGridCellsPanel(XXmlNode xnode) {}
   public virtual void OnDataGridCellsPresenter(XXmlNode xnode) {}
   public virtual void OnDataGridCheckBoxColumn(XXmlNode xnode) {}
   public virtual void OnDataGridColumn(XXmlNode xnode) {}
   public virtual void OnDataGridColumnEventArgs(XXmlNode xnode) {}
   public virtual void OnDataGridColumnHeader(XXmlNode xnode) {}
   public virtual void OnDataGridColumnHeaderAutomationPeer(XXmlNode xnode) {}
   public virtual void OnDataGridColumnHeaderItemAutomationPeer(XXmlNode xnode) {}
   public virtual void OnDataGridColumnHeadersPresenter(XXmlNode xnode) {}
   public virtual void OnDataGridColumnHeadersPresenterAutomationPeer(XXmlNode xnode) {}
   public virtual void OnDataGridColumnReorderingEventArgs(XXmlNode xnode) {}
   public virtual void OnDataGridComboBoxColumn(XXmlNode xnode) {}
   public virtual void OnDataGridDetailsPresenter(XXmlNode xnode) {}
   public virtual void OnDataGridDetailsPresenterAutomationPeer(XXmlNode xnode) {}
   public virtual void OnDataGridHyperlinkColumn(XXmlNode xnode) {}
   public virtual void OnDataGridItemAutomationPeer(XXmlNode xnode) {}
   public virtual void OnDataGridRow(XXmlNode xnode) {}
   public virtual void OnDataGridRowAutomationPeer(XXmlNode xnode) {}
   public virtual void OnDataGridRowHeader(XXmlNode xnode) {}
   public virtual void OnDataGridRowHeaderAutomationPeer(XXmlNode xnode) {}
   public virtual void OnDataGridRowsPresenter(XXmlNode xnode) {}
   public virtual void OnDataGridSortingEventArgs(XXmlNode xnode) {}
   public virtual void OnDataGridTemplateColumn(XXmlNode xnode) {}
   public virtual void OnDataGridTextColumn(XXmlNode xnode) {}
   public virtual void OnDataObjectCopyingEventArgs(XXmlNode xnode) {}
   public virtual void OnDataObjectEventArgs(XXmlNode xnode) {}
   public virtual void OnDataObjectPastingEventArgs(XXmlNode xnode) {}
   public virtual void OnDataObjectSettingDataEventArgs(XXmlNode xnode) {}
   public virtual void OnDataSourceProvider(XXmlNode xnode) {}
   public virtual void OnDataStateBehavior(XXmlNode xnode) {}
   public virtual void OnDataStoreChangedTrigger(XXmlNode xnode) {}
   public virtual void OnDataTemplate(XXmlNode xnode) {}
   public virtual void OnDataTemplateKey(XXmlNode xnode) {}
   public virtual void OnDataTransferEventArgs(XXmlNode xnode) {}
   public virtual void OnDataTrigger(XXmlNode xnode) {}
   public virtual void OnDatePicker(XXmlNode xnode) {}
   public virtual void OnDatePickerAutomationPeer(XXmlNode xnode) {}
   public virtual void OnDatePickerTextBox(XXmlNode xnode) {}
   public virtual void OnDateTimeAutomationPeer(XXmlNode xnode) {}
   public virtual void OnDateTimeValueSerializer(XXmlNode xnode) {}
   public virtual void OnDecimalAnimation(XXmlNode xnode) {}
   public virtual void OnDecimalAnimationBase(XXmlNode xnode) {}
   public virtual void OnDecimalAnimationUsingKeyFrames(XXmlNode xnode) {}
   public virtual void OnDecimalKeyFrame(XXmlNode xnode) {}
   public virtual void OnDecimalKeyFrameCollection(XXmlNode xnode) {}
   public virtual void OnDecorator(XXmlNode xnode) {}
   public virtual void OnDefinitionBase(XXmlNode xnode) {}
   public virtual void OnDependencyObject(XXmlNode xnode) {}
   public virtual void OnDiffuseMaterial(XXmlNode xnode) {}
   public virtual void OnDirectionalLight(XXmlNode xnode) {}
   public virtual void OnDiscreteBooleanKeyFrame(XXmlNode xnode) {}
   public virtual void OnDiscreteByteKeyFrame(XXmlNode xnode) {}
   public virtual void OnDiscreteCharKevFrame(XXmlNode xnode) {}
   public virtual void OnDiscreteColorKeyFrame(XXmlNode xnode) {}
   public virtual void OnDiscreteDecimalKeyFrame(XXmlNode xnode) {}
   public virtual void OnDiscreteDoubleKeyFrame(XXmlNode xnode) {}
   public virtual void OnDiscreteInt16KevFrame(XXmlNode xnode) {}
   public virtual void OnDiscreteInt32KeyFrame(XXmlNode xnode) {}
   public virtual void OnDiscretent64KeyFrame(XXmlNode xnode) {}
   public virtual void OnDiscretelMatrixKeyFrame(XXmlNode xnode) {}
   public virtual void OnDiscereteObjectKeyFrame(XXmlNode xnode) {}
   public virtual void OnDiscretePoint3DKeyFrame(XXmlNode xnode) {}
   public virtual void OnDiscretePointKeyFrame(XXmlNode xnode) {}
   public virtual void OnDiscreteQuaternionKeyFrame(XXmlNode xnode) {}
   public virtual void OnDiscreteRectKeyFrame(XXmlNode xnode) {}
   public virtual void OnDiscreteRotation3DKeyFramne(XXmlNode xnode) {}
   public virtual void OnDiscreteSingleKeyFrame(XXmlNode xnode) {}
   public virtual void OnDiscreteSizeKeyFrame(XXmlNode xnode) {}
   public virtual void OnDiscreteStringKeyFrame(XXmlNode xnode) {}
   public virtual void OnDiscreteThicknessKeyFrame(XXmlNode xnode) {}
   public virtual void OnDiscreteVector3DKeyFrame(XXmlNode xnode) {}
   public virtual void OnDiscreteVectorKeyFrame(XXmlNode xnode) {}
   public virtual void OnDispatcherEventArgs(XXmlNode xnode) {}
   public virtual void OnDispatcherFrame(XXmlNode xnode) {}
   public virtual void OnDispatcherObject(XXmlNode xnode) {}
   public virtual void OnDispatcherOperation(XXmlNode xnode) {}
   public virtual void OnDispatcherUnhandledExceptionEventArgs(XXmlNode xnode) {}
   public virtual void OnDispatcherUnhandledExceptionFilterEventArgs(XXmlNode xnode) {}
   public virtual void OnDockPanel(XXmlNode xnode) {}
   public virtual void OnDocumentAutomationPeer(XXmlNode xnode) {}
   public virtual void OnDocumentViewerAutomationPeer(XXmlNode xnode) {}
   public virtual void OnDocumentPageView(XXmlNode xnode) {}
   public virtual void OnDocumentPageViewAutomationPeer(XXmlNode xnode) {}
   public virtual void OnDocumentPaginator(XXmlNode xnode) {}
   public virtual void OnDocumentReference(XXmlNode xnode) {}
   public virtual void OnDocumentViewer(XXmlNode xnode) {}
   public virtual void OnDocumentViewerBaseAutomationPeer(XXmlNode xnode) {}
   public virtual void OnDoCumentViewerBase(XXmlNode xnode) {}
   public virtual void OnDoubleAnimation(XXmlNode xnode) {}
   public virtual void OnDoubleAnimationBase(XXmlNode xnode) {}
   public virtual void OnDoubleAmimationUsingKevFrames(XXmlNode xnode) {}
   public virtual void OnDoubleAnimationsingPath(XXmlNode xnode) {}
   public virtual void OnDoubleCollection(XXmlNode xnode) {}
   public virtual void OnDoubleCollectionValueSenalizer(XXmlNode xnode) {}
   public virtual void OnDoubleIListConverter(XXmlNode xnode) {}
   public virtual void OnDoubleKeyFrame(XXmlNode xnode) {}
   public virtual void OnDoubleKeyFrameCollection(XXmlNode xnode) {}
   public virtual void OnDragCompletedEventArgs(XXmlNode xnode) {}
   public virtual void OnDragDeltaEventArgs(XXmlNode xnode) {}
   public virtual void OnDragEventArgs(XXmlNode xnode) {}
   public virtual void OnDragStartedEventArgs(XXmlNode xnode) {}
   public virtual void OnDrawing(XXmlNode xnode) {}
   public virtual void OnDrawingBrush(XXmlNode xnode) {}
   public virtual void OnDrawingCollection(XXmlNode xnode) {}
   public virtual void OnDrawingContext(XXmlNode xnode) {}
   public virtual void OnDrawingGroup(XXmlNode xnode) {}
   public virtual void OnDrawingImage(XXmlNode xnode) {}
   public virtual void OnDrawingVisual(XXmlNode xnode) {}
   public virtual void OnDropShadowBitmapEffect(XXmlNode xnode) {}
   public virtual void OnDropShadowEffect(XXmlNode xnode) {}
   public virtual void OnDynamicDocumentPaginator(XXmlNode xnode) {}
   public virtual void OnDynamicRenderer(XXmlNode xnode) {}
   public virtual void OnDynamicResourceExtension(XXmlNode xnode) {}
   public virtual void OnEasingByteKeyFrame(XXmlNode xnode) {}
   public virtual void OnEasingColorKeyFrame(XXmlNode xnode) {}
   public virtual void OnEasingDecimalKeyFrame(XXmlNode xnode) {}
   public virtual void OnEasingDoubleKeyFrame(XXmlNode xnode) {}
   public virtual void OnEasingFunctionBase(XXmlNode xnode) {}
   public virtual void OnEasingInt16KeyFrame(XXmlNode xnode) {}
   public virtual void OnEasingInt32KeyFrame(XXmlNode xnode) {}
   public virtual void OnEasinglnt64KeyFrame(XXmlNode xnode) {}
   public virtual void OnEasingPoint3DKeyFrame(XXmlNode xnode) {}
   public virtual void OnEasingPointKeyFrame(XXmlNode xnode) {}
   public virtual void OnEasingQuaternionKeyFrame(XXmlNode xnode) {}
   public virtual void OnEasingRectKeyFrame(XXmlNode xnode) {}
   public virtual void OnEasingRotation3DKeyFrame(XXmlNode xnode) {}
   public virtual void OnEasingSingleKeyFrame(XXmlNode xnode) {}
   public virtual void OnEasingSizeKeyFranme(XXmlNode xnode) {}
   public virtual void OnEasingThicknessKeyFrame(XXmlNode xnode) {}
   public virtual void OnEasıngVector3DKeyFrame(XXmlNode xnode) {}
   public virtual void OnEasingVectorKeyFrame(XXmlNode xnode) {}
   public virtual void OnEffect(XXmlNode xnode) {}
   public virtual void OnElasticEase(XXmlNode xnode) {}
   public virtual void OnEllipse(XXmlNode xnode) {}
   public virtual void OnEllipseGeometry(XXmlNode xnode) {}
   public virtual void OnEllipseStylusShape(XXmlNode xnode) {}
   public virtual void OnEmbossBitmapEffect(XXmlNode xnode) {}
   public virtual void OnEmissiveMaterial(XXmlNode xnode) {}
   public virtual void OnErrorsChangedEventManager(XXmlNode xnode) {}
   public virtual void OnEventArgs(XXmlNode xnode) {}
   public virtual void OnEventSetter(XXmlNode xnode) {}
   public virtual void OnEventTrigger(XXmlNode xnode) {}
   public virtual void OnEventTriggerBase(XXmlNode xnode) {}
   public virtual void OnException(XXmlNode xnode) {}
   public virtual void OnExceptionRoutedEventArgs(XXmlNode xnode) {}
   public virtual void OnExceptionValidationRule(XXmlNode xnode) {}
   public virtual void OnExecutedRoutedEventArgs(XXmlNode xnode) {}
   public virtual void OnExpander(XXmlNode xnode) {}
   public virtual void OnExpanderAutomationPeer(XXmlNode xnode) {}
   public virtual void OnExponentialEase(XXmlNode xnode) {}
   public virtual void OnExpression(XXmlNode xnode) {}
   public virtual void OnExpressionConverter(XXmlNode xnode) {}
   public virtual void OnExtendedVisualStateManager(XXmlNode xnode) {}
   public virtual void OnFigure(XXmlNode xnode) {}
   public virtual void OnFigureStructure(XXmlNode xnode) {}
   public virtual void OnFileDialog(XXmlNode xnode) {}
   public virtual void OnFixedDocument(XXmlNode xnode) {}
   public virtual void OnFixedDocumentSequence(XXmlNode xnode) {}
   public virtual void OnFixedPage(XXmlNode xnode) {}
   public virtual void OnFixedPageAutomationPeer(XXmlNode xnode) {}
   public virtual void OnFloater(XXmlNode xnode) {}
   public virtual void OnFlowDocument(XXmlNode xnode) {}
   public virtual void OnFlowDocumentPageViewer(XXmlNode xnode) {}
   public virtual void OnFlowDocumentPageViewerAutomationPeer(XXmlNode xnode) {}
   public virtual void OnFlowDocumentReader(XXmlNode xnode) {}
   public virtual void OnFlowDocumentReaderAutomationPeer(XXmlNode xnode) {}
   public virtual void OnFlowDocumentScrollViewer(XXmlNode xnode) {}
   public virtual void OnFlowDocumentScrollViewerAutomationPeer(XXmlNode xnode) {}
   public virtual void OnFluidMoveBehavior(XXmlNode xnode) {}
   public virtual void OnFluidMoveBehaviorBase(XXmlNode xnode) {}
   public virtual void OnFluidMoveSetTagBehavior(XXmlNode xnode) {}
   public virtual void OnFontFamilyValueSerializer(XXmlNode xnode) {}
   public virtual void OnFormatConvertedBitmap(XXmlNode xnode) {}
   public virtual void OnFrame(XXmlNode xnode) {}
   public virtual void OnFrameAutomationPeer(XXmlNode xnode) {}
   public virtual void OnFrameworkContentElement(XXmlNode xnode) {}
   public virtual void OnFrameworkContentElementAutomationPeer(XXmlNode xnode) {}
   public virtual void OnFrameworkElement(XXmlNode xnode) {}
   public virtual void OnFrameworkElementAutomationPeer(XXmlNode xnode) {}
   public virtual void OnFrameworkPropertyMetadata(XXmlNode xnode) {}
   public virtual void OnFrameworkRichTextComposition(XXmlNode xnode) {}
   public virtual void OnFrameworkTemplate(XXmlNode xnode) {}
   public virtual void OnFrameworkTextComposition(XXmlNode xnode) {}
   public virtual void OnFreezable(XXmlNode xnode) {}
   public virtual void OnFreezableCollection(XXmlNode xnode) {}
   public virtual void OnGeneralTransform(XXmlNode xnode) {}
   public virtual void OnGeneralTransform2DTo3D(XXmlNode xnode) {}
   public virtual void OnGeneralTransform3D(XXmlNode xnode) {}
   public virtual void OnGeneralTransform3DCollection(XXmlNode xnode) {}
   public virtual void OnGeneralTransform3DGroup(XXmlNode xnode) {}
   public virtual void OnGeneralTransform3DTo2D(XXmlNode xnode) {}
   public virtual void OnGeneralTransformCollection(XXmlNode xnode) {}
   public virtual void OnGeneralTransformGroup(XXmlNode xnode) {}
   public virtual void OnGenericRootAutomationPeer(XXmlNode xnode) {}
   public virtual void OnGeometry(XXmlNode xnode) {}
   public virtual void OnGeometry3D(XXmlNode xnode) {}
   public virtual void OnGeometryCollection(XXmlNode xnode) {}
   public virtual void OnGeometryDrawing(XXmlNode xnode) {}
   public virtual void OnGeometryGroup(XXmlNode xnode) {}
   public virtual void OnGeometryHitTestParameters(XXmlNode xnode) {}
   public virtual void OnGeometryHitTestResult(XXmlNode xnode) {}
   public virtual void OnGeometryModel3D(XXmlNode xnode) {}
   public virtual void OnGeometryValueSenalizer(XXmlNode xnode) {}
   public virtual void OnGestureRecognizer(XXmlNode xnode) {}
   public virtual void OnGifBitmapDecoder(XXmlNode xnode) {}
   public virtual void OnGifBitmapEncoder(XXmlNode xnode) {}
   public virtual void OnGiveFeedbackEventArgs(XXmlNode xnode) {}
   public virtual void OnGlyphRunDrawing(XXmlNode xnode) {}
   public virtual void OnGlyphs(XXmlNode xnode) {}
   public virtual void OnGoToStateAction(XXmlNode xnode) {}
   public virtual void OnGradientBrush(XXmlNode xnode) {}
   public virtual void OnGradientStop(XXmlNode xnode) {}
   public virtual void OnGradientStopCollection(XXmlNode xnode) {}
   public virtual void OnGrid(XXmlNode xnode) {}
   public virtual void OnGridSplitter(XXmlNode xnode) {}
   public virtual void OnGridSplitterAutomationPeer(XXmlNode xnode) {}
   public virtual void OnGridView(XXmlNode xnode) {}
   public virtual void OnGridViewCellAutomationPeer(XXmlNode xnode) {}
   public virtual void OnGridViewColumn(XXmlNode xnode) {}
   public virtual void OnGridViewColumnHeader(XXmlNode xnode) {}
   public virtual void OnGidViewColumnHeaderAutomationPeer(XXmlNode xnode) {}
   public virtual void OnGridViewHeaderRowPresenter(XXmlNode xnode) {}
   public virtual void OnGridViewHeaderRowPresenterAutomationPeer(XXmlNode xnode) {}
   public virtual void OnGridViewItemAutomationPeer(XXmlNode xnode) {}
   public virtual void OnGridViewRowPresenter(XXmlNode xnode) {}
   public virtual void OnGridViewRowPresenterBase(XXmlNode xnode) {}
   public virtual void OnGroupBox(XXmlNode xnode) {}
   public virtual void OnGroupBoXAutomationPeer(XXmlNode xnode) {}
   public virtual void OnGroupDescription(XXmlNode xnode) {}
   public virtual void OnGroupltem(XXmlNode xnode) {}
   public virtual void OnGroupItemAutomationPeer(XXmlNode xnode) {}
   public virtual void OnGuidelineSet(XXmlNode xnode) {}
   public virtual void OnHeaderedContentControl(XXmlNode xnode) {}
   public virtual void OnHeaderedItemsControl(XXmlNode xnode) {}
   public virtual void OnHierarchicalDataTemplate(XXmlNode xnode) {}
   public virtual void OnHitTestParameters(XXmlNode xnode) {}
   public virtual void OnHitTestParameters3D(XXmlNode xnode) {}
   public virtual void OnHitTestResult(XXmlNode xnode) {}
   public virtual void OnHostVisual(XXmlNode xnode) {}
   public virtual void OnHwndHost(XXmlNode xnode) {}
   public virtual void OnHwndSource(XXmlNode xnode) {}
   public virtual void OnHwndTarget(XXmlNode xnode) {}
   public virtual void OnHperlınk(XXmlNode xnode) {}
   public virtual void OnHyperlinkAutomationPeer(XXmlNode xnode) {}
   public virtual void OnIconBitmapDecoder(XXmlNode xnode) {}
   public virtual void OnImage(XXmlNode xnode) {}
   public virtual void OnImageAutomationPeer(XXmlNode xnode) {}
   public virtual void OnTmageBrush(XXmlNode xnode) {}
   public virtual void OnImageDrawing(XXmlNode xnode) {}
   public virtual void OnImageetadata(XXmlNode xnode) {}
   public virtual void OnImageSource(XXmlNode xnode) {}
   public virtual void OnImageSourcealueSerializer(XXmlNode xnode) {}
   public virtual void OnIncrementalHitTester(XXmlNode xnode) {}
   public virtual void OnIncrementalLassoHitTester(XXmlNode xnode) {}
   public virtual void OnIncrementalStrokehHitTester(XXmlNode xnode) {}
   public virtual void OnInkCanvas(XXmlNode xnode) {}
   public virtual void OnInkCanvasAutomationPeer(XXmlNode xnode) {}
   public virtual void OnInkCanvasGestureEventArgs(XXmlNode xnode) {}
   public virtual void OnInkCanvasStrokeCollectedEventArgs(XXmlNode xnode) {}
   public virtual void OnInkPresenter(XXmlNode xnode) {}
   public virtual void OnInkPresenterAutomationPeer(XXmlNode xnode) {}
   public virtual void OnInline(XXmlNode xnode) {}
   public virtual void OnInlineUIContainer(XXmlNode xnode) {}
   public virtual void OnInPlaceBitmapMetadata(XXmlNode xnode) {}
   public virtual void OnInputBindıng(XXmlNode xnode) {}
   public virtual void OnInputDevice(XXmlNode xnode) {}
   public virtual void OnInputEventArgs(XXmlNode xnode) {}
   public virtual void OnInputGesture(XXmlNode xnode) {}
   public virtual void OnInputanguageChangedEventArgs(XXmlNode xnode) {}
   public virtual void OnInputLanguageChangingEventArgs(XXmlNode xnode) {}
   public virtual void OnInputanguageEventArgs(XXmlNode xnode) {}
   public virtual void OnInputLanguageManager(XXmlNode xnode) {}
   public virtual void OnInputManager(XXmlNode xnode) {}
   public virtual void OnInputMethod(XXmlNode xnode) {}
   public virtual void OnInt16Animation(XXmlNode xnode) {}
   public virtual void OnInt16AnimationBase(XXmlNode xnode) {}
   public virtual void OnInt16AnimationBaseUsingKeyFrames(XXmlNode xnode) {}
   public virtual void OnInt16KeyFrame(XXmlNode xnode) {}
   public virtual void OnInt16KeyFrameCollection(XXmlNode xnode) {}
   public virtual void OnInt32Animation(XXmlNode xnode) {}
   public virtual void OnInt32AnimationBase(XXmlNode xnode) {}
   public virtual void OnInt32AnimationUsingKeyFrames(XXmlNode xnode) {}
   public virtual void OnInt32Collection(XXmlNode xnode) {}
   public virtual void OnInt32CollecionValueSerializer(XXmlNode xnode) {}
   public virtual void OnInt32KeyFrame(XXmlNode xnode) {}
   public virtual void OnInt32KeyFrameCollection(XXmlNode xnode) {}
   public virtual void OnInt32RectValueSernalizer(XXmlNode xnode) {}
   public virtual void OnInt64Animation(XXmlNode xnode) {}
   public virtual void OnInt64AnimationBase(XXmlNode xnode) {}
   public virtual void OnInt64AnimationUsingKeyFrames(XXmlNode xnode) {}
   public virtual void OnInt64KevFrame(XXmlNode xnode) {}
   public virtual void OnInt64KevFrameCollection(XXmlNode xnode) {}
   public virtual void OnInteropBitmap(XXmlNode xnode) {}
   public virtual void OnInvokeCommandAction(XXmlNode xnode) {}
   public virtual void OnItalic(XXmlNode xnode) {}
   public virtual void OnItemAutomationPeer(XXmlNode xnode) {}
   public virtual void OnItemCollection(XXmlNode xnode) {}
   public virtual void OnItemContainerTernplate(XXmlNode xnode) {}
   public virtual void OnItemContainerTemplateKey(XXmlNode xnode) {}
   public virtual void OnItemsControl(XXmlNode xnode) {}
   public virtual void OnItemsControlAutomationPeer(XXmlNode xnode) {}
   public virtual void OnItemsPanelTernplate(XXmlNode xnode) {}
   public virtual void OnItemsPresenter(XXmlNode xnode) {}
   public virtual void OnJournalEntry(XXmlNode xnode) {}
   public virtual void OnJpegBitmapDecoder(XXmlNode xnode) {}
   public virtual void OnJpegBitmapEncoder(XXmlNode xnode) {}
   public virtual void OnJumpItem(XXmlNode xnode) {}
   public virtual void OnJumpPath(XXmlNode xnode) {}
   public virtual void OnJumpTask(XXmlNode xnode) {}
   public virtual void OnKeyBinding(XXmlNode xnode) {}
   public virtual void OnKeyboardDevice(XXmlNode xnode) {}
   public virtual void OnKeyboardEventArgs(XXmlNode xnode) {}
   public virtual void OnKeyboardFocusChangedEventArgs(XXmlNode xnode) {}
   public virtual void OnKeyboardInputPrOviderAcquireFocusEventArgs(XXmlNode xnode) {}
   public virtual void OnKeyEventArgs(XXmlNode xnode) {}
   public virtual void OnKevGesture(XXmlNode xnode) {}
   public virtual void OnKevGestureValueSerializer(XXmlNode xnode) {}
   public virtual void OnKeySpline(XXmlNode xnode) {}
   public virtual void OnKeyTrigger(XXmlNode xnode) {}
   public virtual void OnKeyValueSerializer(XXmlNode xnode) {}
   public virtual void OnLabel(XXmlNode xnode) {}
   public virtual void OnLabelAutomationPeer(XXmlNode xnode) {}
   public virtual void OnLateBoundBitmapDecoder(XXmlNode xnode) {}
   public virtual void OnLaunchUriOrFileAction(XXmlNode xnode) {}
   public virtual void OnLight(XXmlNode xnode) {}
   public virtual void OnLine(XXmlNode xnode) {}
   public virtual void OnLinearByteKeyFrame(XXmlNode xnode) {}
   public virtual void OnLinearColorKeyFrame(XXmlNode xnode) {}
   public virtual void OnLinearDecimalKeyFrame(XXmlNode xnode) {}
   public virtual void OnLinearDoubleKeyFrame(XXmlNode xnode) {}
   public virtual void OnLinearGradientBrush(XXmlNode xnode) {}
   public virtual void OnLinearInt16KeyFrame(XXmlNode xnode) {}
   public virtual void OnLinearInt32KeyFrame(XXmlNode xnode) {}
   public virtual void OnLinearInt64KeyFrame(XXmlNode xnode) {}
   public virtual void OnLinearPoint3DKeyFrame(XXmlNode xnode) {}
   public virtual void OnLinearPointKeyFrame(XXmlNode xnode) {}
   public virtual void OnLinearQuaternionKeyFrame(XXmlNode xnode) {}
   public virtual void OnLinearRectKeyFrame(XXmlNode xnode) {}
   public virtual void OnLinearRotation3DKeyFrame(XXmlNode xnode) {}
   public virtual void OnLinearSingleKeyFrame(XXmlNode xnode) {}
   public virtual void OnLinearSizeKeyFrame(XXmlNode xnode) {}
   public virtual void OnLinearThicknessKeyFrame(XXmlNode xnode) {}
   public virtual void OnLinearVector3DKeyFrame(XXmlNode xnode) {}
   public virtual void OnLinearVectorKeyFrame(XXmlNode xnode) {}
   public virtual void OnLineBreak(XXmlNode xnode) {}
   public virtual void OnLineGeometry(XXmlNode xnode) {}
   public virtual void OnLineSeement(XXmlNode xnode) {}
   public virtual void OnList(XXmlNode xnode) {}
   public virtual void OnListBox(XXmlNode xnode) {}
   public virtual void OnListBoxAutomationPeer(XXmlNode xnode) {}
   public virtual void OnListBoxltem(XXmlNode xnode) {}
   public virtual void OnListBoxItemAutomationPeer(XXmlNode xnode) {}
   public virtual void OnListBoxItemWrapperAutomationPecer(XXmlNode xnode) {}
   public virtual void OnListColectionView(XXmlNode xnode) {}
   public virtual void OnListItem(XXmlNode xnode) {}
   public virtual void OnListitemStructure(XXmlNode xnode) {}
   public virtual void OnListStructure(XXmlNode xnode) {}
   public virtual void OnListView(XXmlNode xnode) {}
   public virtual void OnListViewAutomationPeer(XXmlNode xnode) {}
   public virtual void OnListViewItem(XXmlNode xnode) {}
   public virtual void OnLostFocusEventManager(XXmlNode xnode) {}
   public virtual void OnManipulationBoundaryFeedbackEvetArgs(XXmlNode xnode) {}
   public virtual void OnManipulationCompletedEventArgs(XXmlNode xnode) {}
   public virtual void OnManipulationDeltaEventArgs(XXmlNode xnode) {}
   public virtual void OnManipulationInertiaStartingEventArgs(XXmlNode xnode) {}
   public virtual void OnManipulationStartedEventArgs(XXmlNode xnode) {}
   public virtual void OnManıpulationStartingErentArgs(XXmlNode xnode) {}
   public virtual void OnMarkupExtension(XXmlNode xnode) {}
   public virtual void OnMaterial(XXmlNode xnode) {}
   public virtual void OnMaterialCollection(XXmlNode xnode) {}
   public virtual void OnMaterialGroup(XXmlNode xnode) {}
   public virtual void OnMatrix3DValueSerializer(XXmlNode xnode) {}
   public virtual void OnMatrixAnimationBase(XXmlNode xnode) {}
   public virtual void OnMatrixAnimationUsingKeyFrames(XXmlNode xnode) {}
   public virtual void OnMatrixAnimationUsingPath(XXmlNode xnode) {}
   public virtual void OnMatrixCamera(XXmlNode xnode) {}
   public virtual void OnMatrixKeyFrame(XXmlNode xnode) {}
   public virtual void OnMatrixKeyFrameCollection(XXmlNode xnode) {}
   public virtual void OnMatrixTransform(XXmlNode xnode) {}
   public virtual void OnMatrixTransform3D(XXmlNode xnode) {}
   public virtual void OnMatrixValueSerializer(XXmlNode xnode) {}
   public virtual void OnMediaClock(XXmlNode xnode) {}
   public virtual void OnMediaElement(XXmlNode xnode) {}
   public virtual void OnMediaElementAutomationPeer(XXmlNode xnode) {}
   public virtual void OnMediaPlayer(XXmlNode xnode) {}
   public virtual void OnMediaScriptCommandRoutedEventArgs(XXmlNode xnode) {}
   public virtual void OnMediaTimeline(XXmlNode xnode) {}
   public virtual void OnMemberDefinition(XXmlNode xnode) {}
   public virtual void OnMenu(XXmlNode xnode) {}
   public virtual void OnMenuAutomationPeer(XXmlNode xnode) {}
   public virtual void OnMenuBase(XXmlNode xnode) {}
   public virtual void OnMenuItem(XXmlNode xnode) {}
   public virtual void OnMenuItemAutomationPeer(XXmlNode xnode) {}
   public virtual void OnMeshGeometry3D(XXmlNode xnode) {}
   public virtual void OnModel3D(XXmlNode xnode) {}
   public virtual void OnModel3DCollection(XXmlNode xnode) {}
   public virtual void OnModel3DGroup(XXmlNode xnode) {}
   public virtual void OnModelUIElement3D(XXmlNode xnode) {}
   public virtual void OnModelVisual3D(XXmlNode xnode) {}
   public virtual void OnModifierKeysValueSerializer(XXmlNode xnode) {}
   public virtual void OnMouseActionValueSerializer(XXmlNode xnode) {}
   public virtual void OnMouseBinding(XXmlNode xnode) {}
   public virtual void OnMouseButtonEventArgs(XXmlNode xnode) {}
   public virtual void OnMouseDevice(XXmlNode xnode) {}
   public virtual void OnMouseDragElementBehavior(XXmlNode xnode) {}
   public virtual void OnMouseEventArgs(XXmlNode xnode) {}
   public virtual void OnMouseGesture(XXmlNode xnode) {}
   public virtual void OnMouseGestureValueSerializer(XXmlNode xnode) {}
   public virtual void OnMouseWheelEventArgs(XXmlNode xnode) {}
   public virtual void OnMultiBinding(XXmlNode xnode) {}
   public virtual void OnMultiBindingExpression(XXmlNode xnode) {}
   public virtual void OnMultiDataTrigger(XXmlNode xnode) {}
   public virtual void OnMultiSelector(XXmlNode xnode) {}
   public virtual void OnMultiTrigger(XXmlNode xnode) {}
   public virtual void OnNamedElement(XXmlNode xnode) {}
   public virtual void OnNavigationWindow(XXmlNode xnode) {}
   public virtual void OnNavigationWindowAutomationPeer(XXmlNode xnode) {}
   public virtual void OnNotifyDataErrorValidationRule(XXmlNode xnode) {}
   public virtual void OnNotifyInputEventArgs(XXmlNode xnode) {}
   public virtual void OnNullExtension(XXmlNode xnode) {}
   public virtual void OnObjectAnimationBase(XXmlNode xnode) {}
   public virtual void OnObjectAnimationUsingKeyFrames(XXmlNode xnode) {}
   public virtual void OnObjectDataProvider(XXmlNode xnode) {}
   public virtual void OnObjectKeyFrame(XXmlNode xnode) {}
   public virtual void OnObjectKeyFrameCollection(XXmlNode xnode) {}
   public virtual void OnOpenFileDialog(XXmlNode xnode) {}
   public virtual void OnOrthographicCamera(XXmlNode xnode) {}
   public virtual void OnOuterGlowBitmapEffect(XXmlNode xnode) {}
   public virtual void OnPackage(XXmlNode xnode) {}
   public virtual void OnPackagePart(XXmlNode xnode) {}
   public virtual void OnPage(XXmlNode xnode) {}
   public virtual void OnPageContent(XXmlNode xnode) {}
   public virtual void OnPageFunction(XXmlNode xnode) {}
   public virtual void OnPageFunctionBase(XXmlNode xnode) {}
   public virtual void OnPanel(XXmlNode xnode) {}
   public virtual void OnParagraph(XXmlNode xnode) {}
   public virtual void OnParagraphStructure(XXmlNode xnode) {}
   public virtual void OnParallelTimeline(XXmlNode xnode) {}
   public virtual void OnPasswordBox(XXmlNode xnode) {}
   public virtual void OnPasswordBoxAutomationPeer(XXmlNode xnode) {}
   public virtual void OnPath(XXmlNode xnode) {}
   public virtual void OnPathFigure(XXmlNode xnode) {}
   public virtual void OnPathFigureCollection(XXmlNode xnode) {}
   public virtual void OnPathFigureCollectionValueSenalizer(XXmlNode xnode) {}
   public virtual void OnPathGeometry(XXmlNode xnode) {}
   public virtual void OnPathSegment(XXmlNode xnode) {}
   public virtual void OnPathSegmentCollection(XXmlNode xnode) {}
   public virtual void OnPauseStoryboard(XXmlNode xnode) {}
   public virtual void OnPen(XXmlNode xnode) {}
   public virtual void OnPerspectiveCamera(XXmlNode xnode) {}
   public virtual void OnPixelShader(XXmlNode xnode) {}
   public virtual void OnPlaySoundAction(XXmlNode xnode) {}
   public virtual void OnPngBitmapDecoder(XXmlNode xnode) {}
   public virtual void OnPngBitmapEncoder(XXmlNode xnode) {}
   public virtual void OnPoint3DAnimation(XXmlNode xnode) {}
   public virtual void OnPoint3DAnimationBase(XXmlNode xnode) {}
   public virtual void OnPoint3DAnimationUsingKeyFrames(XXmlNode xnode) {}
   public virtual void OnPoint3DCollection(XXmlNode xnode) {}
   public virtual void OnPoint3DCollectionValueSerializer(XXmlNode xnode) {}
   public virtual void OnPoint3DKeyFrame(XXmlNode xnode) {}
   public virtual void OnPoint3DKeyFrameCollection(XXmlNode xnode) {}
   public virtual void OnPoint3DValueSerializer(XXmlNode xnode) {}
   public virtual void OnPoint4DValueSerializer(XXmlNode xnode) {}
   public virtual void OnPointAnimation(XXmlNode xnode) {}
   public virtual void OnPointAnimationBase(XXmlNode xnode) {}
   public virtual void OnPointAnimationUsingKeyFrames(XXmlNode xnode) {}
   public virtual void OnPointAnimationUsingPath(XXmlNode xnode) {}
   public virtual void OnPointCollection(XXmlNode xnode) {}
   public virtual void OnPointCollectionValueSerializer(XXmlNode xnode) {}
   public virtual void OnPointHitTestParameters(XXmlNode xnode) {}
   public virtual void OnPointHitTestResult(XXmlNode xnode) {}
   public virtual void OnPointIListConverter(XXmlNode xnode) {}
   public virtual void OnPointKeyFrame(XXmlNode xnode) {}
   public virtual void OnPointKeyFrameCollection(XXmlNode xnode) {}
   public virtual void OnPointLight(XXmlNode xnode) {}
   public virtual void OnPointLightBase(XXmlNode xnode) {}
   public virtual void OnPointValueSerializer(XXmlNode xnode) {}
   public virtual void OnPolyBezierSegment(XXmlNode xnode) {}
   public virtual void OnPolygon(XXmlNode xnode) {}
   public virtual void OnPolylıne(XXmlNode xnode) {}
   public virtual void OnPolyLineSegment(XXmlNode xnode) {}
   public virtual void OnPolyQuadraticBezierSegment(XXmlNode xnode) {}
   public virtual void OnPopup(XXmlNode xnode) {}
   public virtual void OnPowerEase(XXmlNode xnode) {}
   public virtual void OnPreProcessInputEventArgs(XXmlNode xnode) {}
   public virtual void OnPresentationSource(XXmlNode xnode) {}
   public virtual void OnPriorityBinding(XXmlNode xnode) {}
   public virtual void OnPriorityBindingExpression(XXmlNode xnode) {}
   public virtual void OnProcessInputEventArgs(XXmlNode xnode) {}
   public virtual void OnProgressBar(XXmlNode xnode) {}
   public virtual void OnProgressBarAutomattonPeer(XXmlNode xnode) {}
   public virtual void OnProjectionCamera(XXmlNode xnode) {}
   public virtual void OnPropertyChangedEventManager(XXmlNode xnode) {}
   public virtual void OnPropertyChangedTrigger(XXmlNode xnode) {}
   public virtual void OnPropertyDefinition(XXmlNode xnode) {}
   public virtual void OnPropertyGroupDescription(XXmlNode xnode) {}
   public virtual void OnPropertyMetadata(XXmlNode xnode) {}
   public virtual void OnQuadraticBezierSegment(XXmlNode xnode) {}
   public virtual void OnOuadraticEase(XXmlNode xnode) {}
   public virtual void OnQuarticEase(XXmlNode xnode) {}
   public virtual void OnQuaternionAnimation(XXmlNode xnode) {}
   public virtual void OnQuaternionAnimationBase(XXmlNode xnode) {}
   public virtual void OnQuaternionAnimationUsingKeyFrames(XXmlNode xnode) {}
   public virtual void OnQuaternionKeyFrame(XXmlNode xnode) {}
   public virtual void OnQuaternionKeyFrameCollection(XXmlNode xnode) {}
   public virtual void OnQuaternionRotation3D(XXmlNode xnode) {}
   public virtual void OnQuaternionValueSerializer(XXmlNode xnode) {}
   public virtual void OnQueryContinueDragEventArgs(XXmlNode xnode) {}
   public virtual void OnQueryCursorEventArgs(XXmlNode xnode) {}
   public virtual void OnQuinticEase(XXmlNode xnode) {}
   public virtual void OnRadialGradientBrush(XXmlNode xnode) {}
   public virtual void OnRadioButton(XXmlNode xnode) {}
   public virtual void OnRadioButtonAutomationPeer(XXmlNode xnode) {}
   public virtual void OnRangeBase(XXmlNode xnode) {}
   public virtual void OnRangeBaseAutomationPeer(XXmlNode xnode) {}
   public virtual void OnRayHitTestParameters(XXmlNode xnode) {}
   public virtual void OnRayHitTestResult(XXmlNode xnode) {}
   public virtual void OnRayMeshGeometry3DHitTestResult(XXmlNode xnode) {}
   public virtual void OnRect3DValueSerializer(XXmlNode xnode) {}
   public virtual void OnRectangle(XXmlNode xnode) {}
   public virtual void OnRectangleGeometry(XXmlNode xnode) {}
   public virtual void OnRectangleStylusShape(XXmlNode xnode) {}
   public virtual void OnRectAnimation(XXmlNode xnode) {}
   public virtual void OnRectAnimationBase(XXmlNode xnode) {}
   public virtual void OnRectAnimationUsingKeyFrames(XXmlNode xnode) {}
   public virtual void OnRectKeyFrame(XXmlNode xnode) {}
   public virtual void OnRectKeyFrameCollection(XXmlNode xnode) {}
   public virtual void OnRectValueSerializer(XXmlNode xnode) {}
   public virtual void OnReference(XXmlNode xnode) {}
   public virtual void OnRelativeSource(XXmlNode xnode) {}
   public virtual void OnRemoveElementAction(XXmlNode xnode) {}
   public virtual void OnRemoveStoryboard(XXmlNode xnode) {}
   public virtual void OnRenderTargetBitmap(XXmlNode xnode) {}
   public virtual void OnRepeteButton(XXmlNode xnode) {}
   public virtual void OnRepeatButtonAutomationPeer(XXmlNode xnode) {}
   public virtual void OnRequestBringIntoViewEventArgs(XXmlNode xnode) {}
   public virtual void OnRequestNavigateEventArgs(XXmlNode xnode) {}
   public virtual void OnResizeGrip(XXmlNode xnode) {}
   public virtual void OnResourceKey(XXmlNode xnode) {}
   public virtual void OnResourceReferenceExpressionConverter(XXmlNode xnode) {}
   public virtual void OnResumeStoryboard(XXmlNode xnode) {}
   public virtual void OnRichTextBox(XXmlNode xnode) {}
   public virtual void OnRichTextBoxAutomationPeer(XXmlNode xnode) {}
   public virtual void OnRotateTransform(XXmlNode xnode) {}
   public virtual void OnRotateTransform3D(XXmlNode xnode) {}
   public virtual void OnRotation3D(XXmlNode xnode) {}
   public virtual void OnRotation3DAnimation(XXmlNode xnode) {}
   public virtual void OnRotation3DAnimationBase(XXmlNode xnode) {}
   public virtual void OnRotation3DAnimationUsingKeyFrames(XXmlNode xnode) {}
   public virtual void OnRotation3DKeyFrame(XXmlNode xnode) {}
   public virtual void OnRotation3DKeyFrameCollection(XXmlNode xnode) {}
   public virtual void OnRoutedCommand(XXmlNode xnode) {}
   public virtual void OnRoutedEventArgs(XXmlNode xnode) {}
   public virtual void OnRoutedPropertyChangedEventArgs(XXmlNode xnode) {}
   public virtual void OnRoutedUICommand(XXmlNode xnode) {}
   public virtual void OnRowDefinition(XXmlNode xnode) {}
   public virtual void OnRun(XXmlNode xnode) {}
   public virtual void OnSaveFileDialog(XXmlNode xnode) {}
   public virtual void OnScaleTransform(XXmlNode xnode) {}
   public virtual void OnScaleTransform3D(XXmlNode xnode) {}
   public virtual void OnScrollBar(XXmlNode xnode) {}
   public virtual void OnScrollBarAutomationPeer(XXmlNode xnode) {}
   public virtual void OnScrollChangedEventArgs(XXmlNode xnode) {}
   public virtual void OnScrollContentPresenter(XXmlNode xnode) {}
   public virtual void OnSerollEventArgs(XXmlNode xnode) {}
   public virtual void OnScrollViewer(XXmlNode xnode) {}
   public virtual void OnScrollViewerAutomationPeer(XXmlNode xnode) {}
   public virtual void OnSection(XXmlNode xnode) {}
   public virtual void OnSectionStructure(XXmlNode xnode) {}
   public virtual void OnSeekStoryboard(XXmlNode xnode) {}
   public virtual void OnSelectionChangedEventArgs(XXmlNode xnode) {}
   public virtual void OnSelectiveScrollingGrid(XXmlNode xnode) {}
   public virtual void OnSelector(XXmlNode xnode) {}
   public virtual void OnSelectorAutomationPeer(XXmlNode xnode) {}
   public virtual void OnSelectorItemAutomationPeer(XXmlNode xnode) {}
   public virtual void OnSemanticBasicElement(XXmlNode xnode) {}
   public virtual void OnSeparator(XXmlNode xnode) {}
   public virtual void OnSeparatorAutomationPeer(XXmlNode xnode) {}
   public virtual void OnServiceProviders(XXmlNode xnode) {}
   public virtual void OnSetDataStoreValueAction(XXmlNode xnode) {}
   public virtual void OnSetStoryboardSpeedRatio(XXmlNode xnode) {}
   public virtual void OnSetter(XXmlNode xnode) {}
   public virtual void OnSetterBase(XXmlNode xnode) {}
   public virtual void OnShaderEfect(XXmlNode xnode) {}
   public virtual void OnShape(XXmlNode xnode) {}
   public virtual void OnSineEase(XXmlNode xnode) {}
   public virtual void OnSingleAnimation(XXmlNode xnode) {}
   public virtual void OnSingleAnimationBase(XXmlNode xnode) {}
   public virtual void OnSingleAnimationUsingKeyFrames(XXmlNode xnode) {}
   public virtual void OnSingleKeyFrame(XXmlNode xnode) {}
   public virtual void OnSingleKeyFrameCollection(XXmlNode xnode) {}
   public virtual void OnSize3DValueSerializer(XXmlNode xnode) {}
   public virtual void OnSizeAnimation(XXmlNode xnode) {}
   public virtual void OnSizeAnimationBase(XXmlNode xnode) {}
   public virtual void OnSizeAnimationUsingKeyFrames(XXmlNode xnode) {}
   public virtual void OnSizeChangedEventArgs(XXmlNode xnode) {}
   public virtual void OnSizeKeyFrame(XXmlNode xnode) {}
   public virtual void OnSizeKeyFrameCollection(XXmlNode xnode) {}
   public virtual void OnSizeValueSerializer(XXmlNode xnode) {}
   public virtual void OnSkewTransform(XXmlNode xnode) {}
   public virtual void OnSkipStoryboardToFill(XXmlNode xnode) {}
   public virtual void OnSlider(XXmlNode xnode) {}
   public virtual void OnSiderAutomationPeer(XXmlNode xnode) {}
   public virtual void OnSolidColorBrush(XXmlNode xnode) {}
   public virtual void OnSoundPlayerAction(XXmlNode xnode) {}
   public virtual void OnSourceChangedEventArgs(XXmlNode xnode) {}
   public virtual void OnSpan(XXmlNode xnode) {}
   public virtual void OnSpecularMaterial(XXmlNode xnode) {}
   public virtual void OnSplineByteKeyFrame(XXmlNode xnode) {}
   public virtual void OnSplıneColorKeyFrame(XXmlNode xnode) {}
   public virtual void OnSplineDecimalKeyFrame(XXmlNode xnode) {}
   public virtual void OnSplineDoubleKeyFrame(XXmlNode xnode) {}
   public virtual void OnSplinelnt16KeyFrame(XXmlNode xnode) {}
   public virtual void OnSplinelnt32KeyFrame(XXmlNode xnode) {}
   public virtual void OnSplinelnt64KeyFrame(XXmlNode xnode) {}
   public virtual void OnSplinePoint3DKeyFrame(XXmlNode xnode) {}
   public virtual void OnSplinePointKevFrame(XXmlNode xnode) {}
   public virtual void OnSplineQuaternionKeyFrame(XXmlNode xnode) {}
   public virtual void OnSplineRectKeyFrame(XXmlNode xnode) {}
   public virtual void OnSplineRotation3DKeyFrame(XXmlNode xnode) {}
   public virtual void OnSplineSingleKeyFrame(XXmlNode xnode) {}
   public virtual void OnSplineSizeKeyFrame(XXmlNode xnode) {}
   public virtual void OnSplineThicknessKeyFrame(XXmlNode xnode) {}
   public virtual void OnSplineVector3DKeyFrame(XXmlNode xnode) {}
   public virtual void OnSplineVectorKeyFrame(XXmlNode xnode) {}
   public virtual void OnSpotLight(XXmlNode xnode) {}
   public virtual void OnStackPanel(XXmlNode xnode) {}
   public virtual void OnStaticExtension(XXmlNode xnode) {}
   public virtual void OnStaticResourceExtension(XXmlNode xnode) {}
   public virtual void OnStatusBar(XXmlNode xnode) {}
   public virtual void OnStatusBarAutomationPeer(XXmlNode xnode) {}
   public virtual void OnStatusBarItem(XXmlNode xnode) {}
   public virtual void OnStatusBarItemAutomationPeer(XXmlNode xnode) {}
   public virtual void OnStickyNoteControl(XXmlNode xnode) {}
   public virtual void OnStopStoryboard(XXmlNode xnode) {}
   public virtual void OnStoryboard(XXmlNode xnode) {}
   public virtual void OnStoryboardAction(XXmlNode xnode) {}
   public virtual void OnStoryboardCompletedTrigger(XXmlNode xnode) {}
   public virtual void OnStoryboardTrigger(XXmlNode xnode) {}
   public virtual void OnStoryBreak(XXmlNode xnode) {}
   public virtual void OnStreamGeometry(XXmlNode xnode) {}
   public virtual void OnStreamGeometryContext(XXmlNode xnode) {}
   public virtual void OnStringAnimationBase(XXmlNode xnode) {}
   public virtual void OnStringAnimationUsingKevFrames(XXmlNode xnode) {}
   public virtual void OnStringKeyFrame(XXmlNode xnode) {}
   public virtual void OnStringKeyFrameCollection(XXmlNode xnode) {}
   public virtual void OnStyle(XXmlNode xnode) {}
   public virtual void OnStylusButtonEventArgs(XXmlNode xnode) {}
   public virtual void OnStylusDevice(XXmlNode xnode) {}
   public virtual void OnStylusDownEventArgs(XXmlNode xnode) {}
   public virtual void OnStylusPlugIn(XXmlNode xnode) {}
   public virtual void OnStylusEventArgs(XXmlNode xnode) {}
   public virtual void OnStylusPontProperty(XXmlNode xnode) {}
   public virtual void OnStylusPointPropertyInfo(XXmlNode xnode) {}
   public virtual void OnStylusShape(XXmlNode xnode) {}
   public virtual void OnStylusSystemGestureEventArgs(XXmlNode xnode) {}
   public virtual void OnTabControl(XXmlNode xnode) {}
   public virtual void OnTabControlAutomationPeer(XXmlNode xnode) {}
   public virtual void OnTabItern(XXmlNode xnode) {}
   public virtual void OnTabItenAutomationPeer(XXmlNode xnode) {}
   public virtual void OnTabItemWrapperAutomationPeer(XXmlNode xnode) {}
   public virtual void OnTable(XXmlNode xnode) {}
   public virtual void OnTableAutomationPeer(XXmlNode xnode) {}
   public virtual void OnTableCell(XXmlNode xnode) {}
   public virtual void OnTableCellAutomationPeer(XXmlNode xnode) {}
   public virtual void OnTableCellStructure(XXmlNode xnode) {}
   public virtual void OnTableColumn(XXmlNode xnode) {}
   public virtual void OnTableRow(XXmlNode xnode) {}
   public virtual void OnTableRowGroup(XXmlNode xnode) {}
   public virtual void OnTableRowGroupStructure(XXmlNode xnode) {}
   public virtual void OnTableRowStructure(XXmlNode xnode) {}
   public virtual void OnTableStructure(XXmlNode xnode) {}
   public virtual void OnTabletDevice(XXmlNode xnode) {}
   public virtual void OnTabPanel(XXmlNode xnode) {}
   public virtual void OnTargetedTriggerAction(XXmlNode xnode) {}
   public virtual void OnTaskbarltemInfo(XXmlNode xnode) {}
   public virtual void OnTemplateBindingExpression(XXmlNode xnode) {}
   public virtual void OnTemplateBindingExtension(XXmlNode xnode) {}
   public virtual void OnTemplateContentLoader(XXmlNode xnode) {}
   public virtual void OnTemplateKey(XXmlNode xnode) {}
   public virtual void OnTextAutomationPeer(XXmlNode xnode) {}
   public virtual void OnTextBlock(XXmlNode xnode) {}
   public virtual void OnTextBlockAutomationPeer(XXmlNode xnode) {}
   public virtual void OnTextBox(XXmlNode xnode) {}
   public virtual void OnTextBoxAutomationPeer(XXmlNode xnode) {}
   public virtual void OnTextBoxBase(XXmlNode xnode) {}
   public virtual void OnTextChangedEventArgs(XXmlNode xnode) {}
   public virtual void OnTextCharacters(XXmlNode xnode) {}
   public virtual void OnTextCollapsingProperties(XXmlNode xnode) {}
   public virtual void OnTextComposıtion(XXmlNode xnode) {}
   public virtual void OnTextCompositionEventArgs(XXmlNode xnode) {}
   public virtual void OnTextCompositionManager(XXmlNode xnode) {}
   public virtual void OnTextDecoration(XXmlNode xnode) {}
   public virtual void OnTextDecorationCollection(XXmlNode xnode) {}
   public virtual void OnTextEffect(XXmlNode xnode) {}
   public virtual void OnTextEftectCollection(XXmlNode xnode) {}
   public virtual void OnTextElement(XXmlNode xnode) {}
   public virtual void OnTextElementAutomationPeer(XXmlNode xnode) {}
   public virtual void OnTextEmbeddedObject(XXmlNode xnode) {}
   public virtual void OnTextEndOfLine(XXmlNode xnode) {}
   public virtual void OnTextEndOfParagraph(XXmlNode xnode) {}
   public virtual void OnTextEndOfSegment(XXmlNode xnode) {}
   public virtual void OnTextHidden(XXmlNode xnode) {}
   public virtual void OnTextMarkerProperties(XXmlNode xnode) {}
   public virtual void OnTextModifier(XXmlNode xnode) {}
   public virtual void OnTextPointer(XXmlNode xnode) {}
   public virtual void OnTextRange(XXmlNode xnode) {}
   public virtual void OnTextRun(XXmlNode xnode) {}
   public virtual void OnTextSearch(XXmlNode xnode) {}
   public virtual void OnTextSelection(XXmlNode xnode) {}
   public virtual void OnTextSimpleMarkerProperties(XXmlNode xnode) {}
   public virtual void OnTextTrailingCharacterEllipsis(XXmlNode xnode) {}
   public virtual void OnTextTrailingWordEllipsis(XXmlNode xnode) {}
   public virtual void OnThemeDictionaryExtension(XXmlNode xnode) {}
   public virtual void OnThicknessAnimation(XXmlNode xnode) {}
   public virtual void OnThicknessAnimationBase(XXmlNode xnode) {}
   public virtual void OnThicknessAnimationUsingKeyFrames(XXmlNode xnode) {}
   public virtual void OnThicknessKeyFrame(XXmlNode xnode) {}
   public virtual void OnThicknessKeyFrameCollection(XXmlNode xnode) {}
   public virtual void OnThumb(XXmlNode xnode) {}
   public virtual void OnThumbAutomationPeer(XXmlNode xnode) {}
   public virtual void OnThumbButonInfo(XXmlNode xnode) {}
   public virtual void OnThumbButtonlnfoCollection(XXmlNode xnode) {}
   public virtual void OnTickBar(XXmlNode xnode) {}
   public virtual void OnTiffBitmap(XXmlNode xnode) {}
   public virtual void OnTiffBitmapEncoder(XXmlNode xnode) {}
   public virtual void OnTileBrush(XXmlNode xnode) {}
   public virtual void OnTimeline(XXmlNode xnode) {}
   public virtual void OnTimelineCollection(XXmlNode xnode) {}
   public virtual void OnTimelıneGroup(XXmlNode xnode) {}
   public virtual void OnTimerTrigger(XXmlNode xnode) {}
   public virtual void OnToggleButton(XXmlNode xnode) {}
   public virtual void OnToggleButtonAutomationPeer(XXmlNode xnode) {}
   public virtual void OnToolBar(XXmlNode xnode) {}
   public virtual void OnTooIBarAutomationPeer(XXmlNode xnode) {}
   public virtual void OnToolBarOverflowPanel(XXmlNode xnode) {}
   public virtual void OnToolBarPanel(XXmlNode xnode) {}
   public virtual void OnToolBarTray(XXmlNode xnode) {}
   public virtual void OnToolTip(XXmlNode xnode) {}
   public virtual void OnToolTipAutomationPeer(XXmlNode xnode) {}
   public virtual void OnToolTipEventArg3G(XXmlNode xnode) {}
   public virtual void OnTouchDevice(XXmlNode xnode) {}
   public virtual void OnTouchDeviceArgs(XXmlNode xnode) {}
   public virtual void OnTrack(XXmlNode xnode) {}
   public virtual void OnTransform(XXmlNode xnode) {}
   public virtual void OnTransform3D(XXmlNode xnode) {}
   public virtual void OnTransformn3DCollection(XXmlNode xnode) {}
   public virtual void OnTransform3DGroup(XXmlNode xnode) {}
   public virtual void OnTransformCollection(XXmlNode xnode) {}
   public virtual void OnTransformedBitmap(XXmlNode xnode) {}
   public virtual void OnTransformGroup(XXmlNode xnode) {}
   public virtual void OnTransformValueSerializer(XXmlNode xnode) {}
   public virtual void OnTransitionEfect(XXmlNode xnode) {}
   public virtual void OnTranslateTransform(XXmlNode xnode) {}
   public virtual void OnTranslateTransfom3D(XXmlNode xnode) {}
   public virtual void OnTranslateZoomRotateBehavior(XXmlNode xnode) {}
   public virtual void OnTreeView(XXmlNode xnode) {}
   public virtual void OnTreeViewAutomationPeer(XXmlNode xnode) {}
   public virtual void OnTreeViewDataltemAutomationPeer(XXmlNode xnode) {}
   public virtual void OnTreeViewItem(XXmlNode xnode) {}
   public virtual void OnTreeViewItemAutomationPeer(XXmlNode xnode) {}
   public virtual void OnTrigger(XXmlNode xnode) {}
   public virtual void OnTriggerAction(XXmlNode xnode) {}
   public virtual void OnTriggerActionCollection(XXmlNode xnode) {}
   public virtual void OnTriggerBase(XXmlNode xnode) {}
   public virtual void OnTriggerCollection(XXmlNode xnode) {}
   public virtual void OnTypeConverter(XXmlNode xnode) {}
   public virtual void OnTypeExtension(XXmlNode xnode) {}
   public virtual void OnUIElement(XXmlNode xnode) {}
   public virtual void OnUElement3D(XXmlNode xnode) {}
   public virtual void OnUIElement3DAutomationPeer(XXmlNode xnode) {}
   public virtual void OnUIElementAutomationPeer(XXmlNode xnode) {}
   public virtual void OnUIPropertyMetadata(XXmlNode xnode) {}
   public virtual void OnUnderline(XXmlNode xnode) {}
   public virtual void OnUniformGrid(XXmlNode xnode) {}
   public virtual void OnUserControl(XXmlNode xnode) {}
   public virtual void OnUserControlAutomationPeer(XXmlNode xnode) {}
   public virtual void OnUShortlListConverter(XXmlNode xnode) {}
   public virtual void OnValidationErrorEventArgs(XXmlNode xnode) {}
   public virtual void OnValidationRule(XXmlNode xnode) {}
   public virtual void OnValueSerializer(XXmlNode xnode) {}
   public virtual void OnVector3DAnimation(XXmlNode xnode) {}
   public virtual void OnVector3DAnimationBase(XXmlNode xnode) {}
   public virtual void OnVector3DAnimationUsingKeyFrames(XXmlNode xnode) {}
   public virtual void OnVector3DCollection(XXmlNode xnode) {}
   public virtual void OnVector3DCollectionValueSerializer(XXmlNode xnode) {}
   public virtual void OnVector3DKeyFrame(XXmlNode xnode) {}
   public virtual void OnVector3DKevFrameCollection(XXmlNode xnode) {}
   public virtual void OnVector3DValueSerializer(XXmlNode xnode) {}
   public virtual void OnVectorAnimation(XXmlNode xnode) {}
   public virtual void OnVectorAnimationBase(XXmlNode xnode) {}
   public virtual void OnVectorAnimationUsingKeyFrames(XXmlNode xnode) {}
   public virtual void OnVectorCollection(XXmlNode xnode) {}
   public virtual void OnVectorCollectionValueSerializer(XXmlNode xnode) {}
   public virtual void OnVectorKeyFrame(XXmlNode xnode) {}
   public virtual void OnVectorKeyFrameCollection(XXmlNode xnode) {}
   public virtual void OnVectorValueSerializer(XXmlNode xnode) {}
   public virtual void OnVideoDrawing(XXmlNode xnode) {}
   public virtual void OnViewBase(XXmlNode xnode) {}
   public virtual void OnViewbox(XXmlNode xnode) {}
   public virtual void OnViewport2DVisual3D(XXmlNode xnode) {}
   public virtual void OnViewport3D(XXmlNode xnode) {}
   public virtual void OnViewport3DAutomationPeer(XXmlNode xnode) {}
   public virtual void OnViewport3DVisual(XXmlNode xnode) {}
   public virtual void OnVrtualizingPanel(XXmlNode xnode) {}
   public virtual void OnVtualizingStackPanel(XXmlNode xnode) {}
   public virtual void OnVisual(XXmlNode xnode) {}
   public virtual void OnVisual3D(XXmlNode xnode) {}
   public virtual void OnVisualBrush(XXmlNode xnode) {}
   public virtual void OnVisualState(XXmlNode xnode) {}
   public virtual void OnVisualStateGroup(XXmlNode xnode) {}
   public virtual void OnVisualStateManager(XXmlNode xnode) {}
   public virtual void OnVisualTarget(XXmlNode xnode) {}
   public virtual void OnVisualTransition(XXmlNode xnode) {}
   public virtual void OnWeakEventManager(XXmlNode xnode) {}
   public virtual void OnWebBrowser(XXmlNode xnode) {}
   public virtual void OnWindow(XXmlNode xnode) {}
   public virtual void OnWindowAutomationPeer(XXmlNode xnode) {}
   public virtual void OnWindowChrome(XXmlNode xnode) {}
   public virtual void OnWmpBitmapDecoder(XXmlNode xnode) {}
   public virtual void OnWmpBitmapEncoder(XXmlNode xnode) {}
   public virtual void OnWrapPanel(XXmlNode xnode) {}
   public virtual void OnWriteableBitmap(XXmlNode xnode) {}
   public virtual void OnXamlBackgroundReader(XXmlNode xnode) {}
   public virtual void OnXamlDeferringLoader(XXmlNode xnode) {}
   public virtual void OnXamlDesignerSernalizationManager(XXmlNode xnode) {}
   public virtual void OnXamlDirective(XXmlNode xnode) {}
   public virtual void OnXamlDuplicateMemberException(XXmlNode xnode) {}
   public virtual void OnXamlException(XXmlNode xnode) {}
   public virtual void OnXamlInternalException(XXmlNode xnode) {}
   public virtual void OnXamlMember(XXmlNode xnode) {}
   public virtual void OnXamlObjectReader(XXmlNode xnode) {}
   public virtual void OnXamlObjectReaderException(XXmlNode xnode) {}
   public virtual void OnXamlObjectReaderSettings(XXmlNode xnode) {}
   public virtual void OnXamlObjectWriter(XXmlNode xnode) {}
   public virtual void OnXamlObjectWriterException(XXmlNode xnode) {}
   public virtual void OnXamlObjectWriterSettings(XXmlNode xnode) {}
   public virtual void OnXamlParseException(XXmlNode xnode) {}
   public virtual void OnXamlReader(XXmlNode xnode) {}
   public virtual void OnXamlReaderSettings(XXmlNode xnode) {}
   public virtual void OnXamlSchemaException(XXmlNode xnode) {}
   public virtual void OnXamlSetMarkupExtensionEventArgs(XXmlNode xnode) {}
   public virtual void OnXamlSetypeConverterEventArgs(XXmlNode xnode) {}
   public virtual void OnXamSetValueEentArgs(XXmlNode xnode) {}
   public virtual void OnXamlWriter(XXmlNode xnode) {}
   public virtual void OnXamlWriterSettings(XXmlNode xnode) {}
   public virtual void OnXamlXmlReader(XXmlNode xnode) {}
   public virtual void OnXamlXmlReaderSettings(XXmlNode xnode) {}
   public virtual void OnXamlXmlWriter(XXmlNode xnode) {}
   public virtual void OnXamlXmlWriterException(XXmlNode xnode) {}
   public virtual void OnXamlXmlWriterSettings(XXmlNode xnode) {}
   public virtual void OnXmlDataProvider(XXmlNode xnode) {}
   public virtual void OnXmlStreamStore(XXmlNode xnode) {}
   public virtual void OnZipPackage(XXmlNode xnode) {}
   public virtual void OnZipPackagePart(XXmlNode xnode) {}
   public abstract void OnDefaultNode(XXmlNode xnode);
}
