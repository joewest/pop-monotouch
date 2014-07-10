## Intro

This project implements MonoTouch C# bindings for the excellent [Facebook Pop](https://github.com/facebook/pop). Check out their project page for a number of great examples and inspiration on how to make the most of the library.

The specific version linked is 1.0 ([commit 2b8dbe17f8](https://github.com/facebook/pop/commit/2b8dbe17f81887ebe6de01acc9420d361e1855ff)).

## Usage

Clone this project, build and reference POP.dll like any other .NET library
(add POP to your app's References).

You can also add POP.csproj to an existing solution and add to References then.

In your app:

```csharp
  using POP;

  //...

  POPSpringAnimation bounce = POPSpringAnimation.AnimationWithPropertyNamed (POPMutableAnimatableProperty.POPViewScaleXY);
  bounce.SpringBounciness = 14;
  bounce.ToValue = NSValue.FromSizeF (new SizeF (1.4f, 1.4f));
  button.PopAddAnimation (bounce, "bounce.me");
```

That's about all you need.

------

_Note:_ The quickest way to get started it to check out the SampleApp. It demonstrates
how to integrate Pop into your MonoTouch app.

A cool feature of Pop is that you can modify animations in flight. You can
also modify a named animation at any point during the animation, even
substituting a new / different type of animation (replace a Spring animation
with a Decay etc).

----

## How do I value?

When specifying [To/From] Values you need to wrap them in the
appropriate native type, e.g. _NSValue.FromType_ or _NSNumber.FromFloat_

**A float**
```csharp
  alphaAnimation.FromValue = NSNumber.FromFloat (0.4f);
```

**An object**
```csharp
  NSValue fromValue = NSValue.FromSizeF (new SizeF (0.5f, 0.5f));
  NSValue toValue = NSValue.FromSizeF (new SizeF (1, 1));
```

## What values do I use?

The [To/From] Values expected by an animation depend on the property being
animated. You can determine what's accepted/required by each by looking up the
property in [POPAnimatableProperty.mm](https://github.com/facebook/pop/blob/master/pop/POPAnimatableProperty.mm).

## Contributing

These bindings are pretty simple. Bug reports and pull requests are always
welcome.

## Todos

* Document property -> value type mapping
* Add more samples (port the very cool [popping](https://github.com/schneiderandre/popping))
* Where's _POPAnimationDragCoefficient_ from POPAnimationExtras.h

## Credits

Originally built for [Moment](http://www.getmoment.co), a new way to enjoy your photos and
videos. Thanks to
[@jeremysomething](https://twitter.com/jeremysomething).
