#import <UIKit/UIKit.h>
#import "UnityAppController.h"

extern "C" void UnitySetGraphicsDevice(void* device, int deviceType, int eventType);
extern "C" void UnityRenderEvent(int marker);

@interface MyAppController : UnityAppController
{
}
- (void)shouldAttachRenderDelegate;
@end

@implementation MyAppController

- (void)shouldAttachRenderDelegate;
{
	UnityRegisterRenderingPlugin(&UnitySetGraphicsDevice, &UnityRenderEvent);
}
@end


IMPL_APP_CONTROLLER_SUBCLASS(MyAppController)

