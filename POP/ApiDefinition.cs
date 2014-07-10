using System;

using MonoTouch.Foundation;
using MonoTouch.CoreAnimation;
using MonoTouch.ObjCRuntime;


namespace POP {

  public delegate void POPAnimatablePropertyInitializerBlock (POPAnimatableProperty property);
  public delegate void POPAnimatablePropertyWriteBlock (NSObject obj, NSArray values);
  public delegate void POPAnimatablePropertyReadBlock (NSObject obj, NSArray values);

  [BaseType (typeof (NSObject))]
  public partial interface POPAnimatableProperty : INSMutableCopying {

    [Static, Export ("propertyWithName:")]
    NSObject PropertyWithName (string name);

    [Static, Export ("propertyWithName:initializer:")]
    NSObject PropertyWithName (string name, POPAnimatablePropertyInitializerBlock block);

    [Export ("name", ArgumentSemantic.Copy)]
    string Name { get; [NotImplemented] set; }

    [Export ("readBlock", ArgumentSemantic.Copy)]
    POPAnimatablePropertyReadBlock ReadBlock { get; [NotImplemented] set; }

    [Export ("writeBlock", ArgumentSemantic.Copy)]
    POPAnimatablePropertyWriteBlock WriteBlock { get; [NotImplemented] set; }

    [Export ("threshold")]
    float Threshold { get; [NotImplemented] set; }
  }

  [BaseType (typeof (POPAnimatableProperty))]
  public partial interface POPMutableAnimatableProperty {

    [Override, Export ("name", ArgumentSemantic.Copy)]
    string Name { get; set; }

    [Override, Export ("readBlock", ArgumentSemantic.Copy)]
    POPAnimatablePropertyReadBlock ReadBlock { get; set; }

    [Override, Export ("writeBlock", ArgumentSemantic.Copy)]
    POPAnimatablePropertyWriteBlock WriteBlock { get; set; }

    [Override, Export ("threshold")]
    float Threshold { get; set; }

    [Field ("kPOPLayerBackgroundColor", "__Internal")]
    NSString POPLayerBackgroundColor { get; }

    [Field ("kPOPLayerBounds", "__Internal")]
    NSString POPLayerBounds { get; }

    [Field ("kPOPLayerCornerRadius", "__Internal")]
    NSString POPLayerCornerRadius { get; }

    [Field ("kPOPLayerOpacity", "__Internal")]
    NSString POPLayerOpacity { get; }

    [Field ("kPOPLayerPosition", "__Internal")]
    NSString POPLayerPosition { get; }

    [Field ("kPOPLayerPositionX", "__Internal")]
    NSString POPLayerPositionX { get; }

    [Field ("kPOPLayerPositionY", "__Internal")]
    NSString POPLayerPositionY { get; }

    [Field ("kPOPLayerRotation", "__Internal")]
    NSString POPLayerRotation { get; }

    [Field ("kPOPLayerRotationX", "__Internal")]
    NSString POPLayerRotationX { get; }

    [Field ("kPOPLayerRotationY", "__Internal")]
    NSString POPLayerRotationY { get; }

    [Field ("kPOPLayerScaleX", "__Internal")]
    NSString POPLayerScaleX { get; }

    [Field ("kPOPLayerScaleXY", "__Internal")]
    NSString POPLayerScaleXY { get; }

    [Field ("kPOPLayerScaleY", "__Internal")]
    NSString POPLayerScaleY { get; }

    [Field ("kPOPLayerSize", "__Internal")]
    NSString POPLayerSize { get; }

    [Field ("kPOPLayerSubscaleXY", "__Internal")]
    NSString POPLayerSubscaleXY { get; }

    [Field ("kPOPLayerSubtranslationX", "__Internal")]
    NSString POPLayerSubtranslationX { get; }

    [Field ("kPOPLayerSubtranslationXY", "__Internal")]
    NSString POPLayerSubtranslationXY { get; }

    [Field ("kPOPLayerSubtranslationY", "__Internal")]
    NSString POPLayerSubtranslationY { get; }

    [Field ("kPOPLayerSubtranslationZ", "__Internal")]
    NSString POPLayerSubtranslationZ { get; }

    [Field ("kPOPLayerTranslationX", "__Internal")]
    NSString POPLayerTranslationX { get; }

    [Field ("kPOPLayerTranslationXY", "__Internal")]
    NSString POPLayerTranslationXY { get; }

    [Field ("kPOPLayerTranslationY", "__Internal")]
    NSString POPLayerTranslationY { get; }

    [Field ("kPOPLayerTranslationZ", "__Internal")]
    NSString POPLayerTranslationZ { get; }

    [Field ("kPOPLayerZPosition", "__Internal")]
    NSString POPLayerZPosition { get; }

    [Field ("kPOPLayerShadowColor", "__Internal")]
    NSString POPLayerShadowColor { get; }

    [Field ("kPOPLayerShadowOffset", "__Internal")]
    NSString POPLayerShadowOffset { get; }

    [Field ("kPOPLayerShadowOpacity", "__Internal")]
    NSString POPLayerShadowOpacity { get; }

    [Field ("kPOPLayerShadowRadius", "__Internal")]
    NSString POPLayerShadowRadius { get; }

    [Field ("kPOPShapeLayerStrokeStart", "__Internal")]
    NSString POPShapeLayerStrokeStart { get; }

    [Field ("kPOPShapeLayerStrokeEnd", "__Internal")]
    NSString POPShapeLayerStrokeEnd { get; }

    [Field ("kPOPShapeLayerStrokeColor", "__Internal")]
    NSString POPShapeLayerStrokeColor { get; }

    [Field ("kPOPLayoutConstraintConstant", "__Internal")]
    NSString POPLayoutConstraintConstant { get; }

    [Field ("kPOPViewAlpha", "__Internal")]
    NSString POPViewAlpha { get; }

    [Field ("kPOPViewBackgroundColor", "__Internal")]
    NSString POPViewBackgroundColor { get; }

    [Field ("kPOPViewBounds", "__Internal")]
    NSString POPViewBounds { get; }

    [Field ("kPOPViewCenter", "__Internal")]
    NSString POPViewCenter { get; }

    [Field ("kPOPViewFrame", "__Internal")]
    NSString POPViewFrame { get; }

    [Field ("kPOPViewScaleX", "__Internal")]
    NSString POPViewScaleX { get; }

    [Field ("kPOPViewScaleXY", "__Internal")]
    NSString POPViewScaleXY { get; }

    [Field ("kPOPViewScaleY", "__Internal")]
    NSString POPViewScaleY { get; }

    [Field ("kPOPViewSize", "__Internal")]
    NSString POPViewSize { get; }

    [Field ("kPOPScrollViewContentOffset", "__Internal")]
    NSString POPScrollViewContentOffset { get; }

    [Field ("kPOPScrollViewContentSize", "__Internal")]
    NSString POPScrollViewContentSize { get; }

    [Field ("kPOPTableViewContentOffset", "__Internal")]
    NSString POPTableViewContentOffset { get; }

    [Field ("kPOPTableViewContentSize", "__Internal")]
    NSString POPTableViewContentSize { get; }

    [Field ("kPOPNavigationBarBarTintColor", "__Internal")]
    NSString POPNavigationBarBarTintColor { get; }

    [Field ("kPOPToolbarBarTintColor", "__Internal")]
    NSString POPToolbarBarTintColor { get; }

    [Field ("kPOPTabBarBarTintColor", "__Internal")]
    NSString POPTabBarBarTintColor { get; }

    [Field ("kPOPLabelTextColor", "__Internal")]
    NSString POPLabelTextColor { get; }
  }

  [BaseType (typeof (NSObject))]
  public partial interface POPAnimationEvent {

    [Export ("type")]
    POPAnimationEventType Type { get; }

    [Export ("time")]
    double Time { get; } //CFTimeInterval Time { get; }

    [Export ("animationDescription", ArgumentSemantic.Copy)]
    string AnimationDescription { get; }
  }

  [BaseType (typeof (POPAnimationEvent))]
  public partial interface POPAnimationValueEvent {

    [Export ("value", ArgumentSemantic.Retain)]
    NSObject Value { get; }

    [Export ("velocity", ArgumentSemantic.Retain)]
    NSObject Velocity { get; }
  }

  [BaseType (typeof (NSObject))]
  public partial interface POPAnimationTracer {

    [Export ("start")]
    void Start ();

    [Export ("stop")]
    void Stop ();

    [Export ("reset")]
    void Reset ();

    [Export ("allEvents", ArgumentSemantic.Assign)]
    NSObject [] AllEvents { get; }

    [Export ("writeEvents", ArgumentSemantic.Assign)]
    NSObject [] WriteEvents { get; }

    [Export ("eventsWithType:")]
    NSObject [] EventsWithType (POPAnimationEventType type);

    [Export ("shouldLogAndResetOnCompletion")]
    bool ShouldLogAndResetOnCompletion { get; set; }
  }

  [BaseType (typeof (NSObject))]
    [Model]
    [Protocol]
  public partial interface POPAnimationDelegate {

    [Export ("pop_animationDidStart:")]
    void Started (POPAnimation anim);

    [Export ("pop_animationDidReachToValue:")]
    void ValueReached (POPAnimation anim);

    [Export ("pop_animationDidStop:finished:"), EventArgs ("POPAnimationFinished")]
    void Finished (POPAnimation anim, bool didFinish);

    [Export ("pop_animationDidApply:")]
    void Applied (POPAnimation anim);
  }

  public delegate void POPAnimationCompletionBlock (POPAnimation animation, bool finished);

  [BaseType (typeof (NSObject),
      Delegates=new string[] {"Delegate"},
      Events=new Type[] { typeof (POPAnimationDelegate) })]
  public partial interface POPAnimation {

    [Wrap ("WeakDelegate")][NullAllowed]
    POPAnimationDelegate Delegate { get; set; }

    [Export ("delegate", ArgumentSemantic.Assign)][NullAllowed]
    NSObject WeakDelegate { get; set; }

    [Export ("name", ArgumentSemantic.Copy)]
    string Name { get; set; }

    [Export ("beginTime")]
    double BeginTime { get; set; } //CFTimeInterval BeginTime { get; set; }

    [Export ("tracer")]
    POPAnimationTracer Tracer { get; }

    [Export ("completionBlock", ArgumentSemantic.Copy)]
    POPAnimationCompletionBlock CompletionBlock { get; set; }

    [Export ("removedOnCompletion")]
    bool RemovedOnCompletion { get; set; }

    [Export ("paused")]
    bool Paused { [Bind ("isPaused")] get; set; }
  }

  [Category, BaseType (typeof (NSObject))]
  public partial interface POP_NSObject {

    [Export ("pop_addAnimation:forKey:")]
    void PopAddAnimation (POPAnimation anim, string key);

    [Export ("pop_removeAllAnimations")]
    void PopRemoveAllAnimations ();

    [Export ("pop_removeAnimationForKey:")]
    void PopRemoveAnimationForKey (string key);

    [Export ("pop_animationKeys")]
    NSObject [] PopAnimationKeys ();

    [Export ("pop_animationForKey:")]
    NSObject PopAnimationForKey (string key);
  }

  [BaseType (typeof (POPAnimation))]
  public partial interface POPPropertyAnimation {

    [Export ("property", ArgumentSemantic.Retain)]
    POPAnimatableProperty Property { get; set; }

    [Export ("fromValue", ArgumentSemantic.Copy)]
    NSObject FromValue { get; set; }

    [Export ("toValue", ArgumentSemantic.Copy)]
    NSObject ToValue { get; set; }

    [Export ("roundingFactor")]
    float RoundingFactor { get; set; }

    [Export ("clampMode")]
    POPAnimationClampFlags ClampMode { get; set; }

    [Export ("additive")]
    bool Additive { [Bind ("isAdditive")] get; set; }
  }

  [BaseType (typeof (POPPropertyAnimation))]
  public partial interface POPSpringAnimation {

    [Static, Export ("animation")]
    POPSpringAnimation Animation { get; }

    [Static, Export ("animationWithPropertyNamed:")]
    POPSpringAnimation AnimationWithPropertyNamed (string name);

    [Export ("velocity", ArgumentSemantic.Copy)]
    NSObject Velocity { get; set; }

    [Export ("springBounciness")]
    float SpringBounciness { get; set; }

    [Export ("springSpeed")]
    float SpringSpeed { get; set; }

    [Export ("dynamicsTension")]
    float DynamicsTension { get; set; }

    [Export ("dynamicsFriction")]
    float DynamicsFriction { get; set; }

    [Export ("dynamicsMass")]
    float DynamicsMass { get; set; }

    // TODO move to top?
    //[DllImport ("/Users/joewest/Projects/src/pop/pop/POPAnimationExtras.h"), Export (null), Verify ("ObjC method massaged into getter property", "/Users/joewest/Projects/src/pop/pop/POPAnimationExtras.h", Line = 19)]
    //float POPAnimationDragCoefficient { get; }
  }

  [Category, BaseType (typeof (CAAnimation))]
  public partial interface POPAnimationExtras_CAAnimation {

    [Export ("pop_applyDragCoefficient")]
    void PopApplyDragCoefficient ();
  }

  [Category, BaseType (typeof (POPSpringAnimation))]
  public partial interface POPAnimationExtras_POPSpringAnimation {

    [Static, Export ("convertBounciness:speed:toTension:friction:mass:")]
    void ConvertBounciness (float bounciness, float speed, [NullAllowed] float outTension, [NullAllowed] float outFriction, [NullAllowed] float outMass);

    [Static, Export ("convertTension:friction:toBounciness:speed:")]
    void ConvertTension (float tension, float friction, [NullAllowed] float outBounciness, [NullAllowed] float outSpeed);
  }

  [Model, Protocol, BaseType (typeof (NSObject))]
  public partial interface POPAnimatorDelegate {

    [Export ("animatorWillAnimate:")]
    void WillAnimate (POPAnimator animator);

    [Export ("animatorDidAnimate:")]
    void DidAnimate (POPAnimator animator);
  }

  [BaseType (typeof (NSObject),
      Delegates=new string[] {"Delegate"},
      Events=new Type[] { typeof (POPAnimatorDelegate) })]
  public partial interface POPAnimator {

    [Wrap ("WeakDelegate")][NullAllowed]
    POPAnimatorDelegate Delegate { get; set; }

    [Export ("delegate", ArgumentSemantic.Assign)][NullAllowed]
    NSObject WeakDelegate { get; set; }

    [Static, Export ("sharedAnimator")]
    POPAnimator SharedAnimator { get; }
  }

  [BaseType (typeof (POPPropertyAnimation))]
  public partial interface POPBasicAnimation {

    [Static, Export ("animation")]
    POPBasicAnimation Animation { get; }

    [Static, Export ("animationWithPropertyNamed:")]
    POPBasicAnimation AnimationWithPropertyNamed (string name);

    [Static, Export ("defaultAnimation")]
    POPBasicAnimation DefaultAnimation { get; }

    [Static, Export ("linearAnimation")]
    POPBasicAnimation LinearAnimation { get; }

    [Static, Export ("easeInAnimation")]
    POPBasicAnimation EaseInAnimation { get; }

    [Static, Export ("easeOutAnimation")]
    POPBasicAnimation EaseOutAnimation { get; }

    [Static, Export ("easeInEaseOutAnimation")]
    POPBasicAnimation EaseInEaseOutAnimation { get; }

    [Export ("duration")]
    double Duration { get; set; } //CFTimeInterval Duration { get; set; }

    [Export ("timingFunction", ArgumentSemantic.Retain)]
    CAMediaTimingFunction TimingFunction { get; set; }
  }

  public delegate bool POPCustomAnimationBlock (NSObject target, POPCustomAnimation animation);

  [BaseType (typeof (POPAnimation))]
  public partial interface POPCustomAnimation {

    [Static, Export ("animationWithBlock:")]
    POPCustomAnimation AnimationWithBlock (POPCustomAnimationBlock block);

    [Export ("currentTime")]
    double CurrentTime { get; } //CFTimeInterval CurrentTime { get; }

    [Export ("elapsedTime")]
    double ElapsedTime { get; } //CFTimeInterval ElapsedTime { get; }
  }

  [BaseType (typeof (POPPropertyAnimation))]
  public partial interface POPDecayAnimation {

    [Static, Export ("animation")]
    POPDecayAnimation Animation { get; }

    [Static, Export ("animationWithPropertyNamed:")]
    POPDecayAnimation AnimationWithPropertyNamed (string name);

    [Export ("velocity", ArgumentSemantic.Copy)]
    NSObject Velocity { get; set; }

    [Export ("deceleration")]
    float Deceleration { get; set; }

    [Export ("duration")]
    double Duration { get; } //CFTimeInterval Duration { get; }
  }

}
