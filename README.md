UPDATE: Working solution now pushed to this repo - see WorkingSolution branch (default). The trick is in the binding declaration and getting to hook to model correctly. A good resource that helped me figure out correct syntax was Gerald Versluis vlog at https://youtu.be/Or_qn8i8jVM Hope this working source helps others.
----------------------------------
ORIGINAL CHALLENGE:
ReproSwipe is repro of SwipeView challenge. In summary, while event fires correctly on a swipe, I'm unable to identify which item in the SwipeView list was acutally swiped. This in turn prevents removing correct item from data set. The sender object coming back to the OnDeleteRequest handler is null. What hooks can be used to identify item that was swiped?

This is taken from a larger project and just shows subset of problem. Hoping to figure this out with help of others as needed. JB

<img width="199" alt="Screen Shot 2022-04-29 at 2 02 34 PM" src="https://user-images.githubusercontent.com/13039619/166089815-2471764a-6343-442e-b1a4-1688197fedfd.png">

