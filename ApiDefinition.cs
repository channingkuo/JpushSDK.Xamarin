using System;
using CoreLocation;
using Foundation;
using ObjCRuntime;
using UIKit;


namespace JPushClient
{
	[Static]
	//[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const kJPFNetworkIsConnectingNotification;
		[Field ("kJPFNetworkIsConnectingNotification", "__Internal")]
		NSString kJPFNetworkIsConnectingNotification { get; }

		// extern NSString *const kJPFNetworkDidSetupNotification;
		[Field ("kJPFNetworkDidSetupNotification", "__Internal")]
		NSString kJPFNetworkDidSetupNotification { get; }

		// extern NSString *const kJPFNetworkDidCloseNotification;
		[Field ("kJPFNetworkDidCloseNotification", "__Internal")]
		NSString kJPFNetworkDidCloseNotification { get; }

		// extern NSString *const kJPFNetworkDidRegisterNotification;
		[Field ("kJPFNetworkDidRegisterNotification", "__Internal")]
		NSString kJPFNetworkDidRegisterNotification { get; }

		// extern NSString *const kJPFNetworkDidLoginNotification;
		[Field ("kJPFNetworkDidLoginNotification", "__Internal")]
		NSString kJPFNetworkDidLoginNotification { get; }

		// extern NSString *const kJPFNetworkDidReceiveMessageNotification;
		[Field ("kJPFNetworkDidReceiveMessageNotification", "__Internal")]
		NSString kJPFNetworkDidReceiveMessageNotification { get; }

		// extern NSString *const kJPFServiceErrorNotification;
		[Field ("kJPFServiceErrorNotification", "__Internal")]
		NSString kJPFServiceErrorNotification { get; }
	}

	// @interface JPUSHService : NSObject
	[BaseType (typeof (NSObject))]
	interface JPUSHService
	{
		// +(void)setupWithOption:(NSDictionary *)launchingOption __attribute__((deprecated("JPush 2.1.0 版本已过期")));
		[Static]
		[Export ("setupWithOption:")]
		void SetupWithOption (NSDictionary launchingOption);

		// +(void)setupWithOption:(NSDictionary *)launchingOption appKey:(NSString *)appKey channel:(NSString *)channel apsForProduction:(BOOL)isProduction;
		[Static]
		[Export ("setupWithOption:appKey:channel:apsForProduction:")]
		void SetupWithOption ([NullAllowed]NSDictionary launchingOption, string appKey, string channel, bool isProduction);

		// +(void)setupWithOption:(NSDictionary *)launchingOption appKey:(NSString *)appKey channel:(NSString *)channel apsForProduction:(BOOL)isProduction advertisingIdentifier:(NSString *)advertisingId;
		[Static]
		[Export ("setupWithOption:appKey:channel:apsForProduction:advertisingIdentifier:")]
		void SetupWithOption (NSDictionary launchingOption, string appKey, string channel, bool isProduction, string advertisingId);

		// +(void)registerForRemoteNotificationTypes:(NSUInteger)types categories:(NSSet *)categories;
		[Static]
		[Export ("registerForRemoteNotificationTypes:categories:")]
		void RegisterForRemoteNotificationTypes (nuint types, [NullAllowed]NSSet categories);

		// +(void)registerDeviceToken:(NSData *)deviceToken;
		[Static]
		[Export ("registerDeviceToken:")]
		void RegisterDeviceToken (NSData deviceToken);

		// +(void)handleRemoteNotification:(NSDictionary *)remoteInfo;
		[Static]
		[Export ("handleRemoteNotification:")]
		void HandleRemoteNotification (NSDictionary remoteInfo);

		// +(void)setTags:(NSSet *)tags alias:(NSString *)alias callbackSelector:(SEL)cbSelector target:(id)theTarget __attribute__((deprecated("JPush 2.1.1 版本已过期")));
		[Static]
		[Export ("setTags:alias:callbackSelector:target:")]
		void SetTags (NSSet tags, string alias, Selector cbSelector, NSObject theTarget);

		// +(void)setTags:(NSSet *)tags alias:(NSString *)alias callbackSelector:(SEL)cbSelector object:(id)theTarget;
		//[Static]
		//[Export ("setTags:alias:callbackSelector:object:")]
		//void SetTags (NSSet tags, string alias, Selector cbSelector, NSObject theTarget);

		// +(void)setTags:(NSSet *)tags callbackSelector:(SEL)cbSelector object:(id)theTarget;
		[Static]
		[Export ("setTags:callbackSelector:object:")]
		void SetTags (NSSet tags, Selector cbSelector, NSObject theTarget);

		// +(void)setTags:(NSSet *)tags alias:(NSString *)alias fetchCompletionHandle:(void (^)(int, NSSet *, NSString *))completionHandler;
		[Static]
		[Export ("setTags:alias:fetchCompletionHandle:")]
		void SetTags (NSSet tags, string alias, Action<int, NSSet, NSString> completionHandler);

		// +(void)setTags:(NSSet *)tags aliasInbackground:(NSString *)alias;
		[Static]
		[Export ("setTags:aliasInbackground:")]
		void SetTags (NSSet tags, string alias);

		// +(void)setAlias:(NSString *)alias callbackSelector:(SEL)cbSelector object:(id)theTarget;
		[Static]
		[Export ("setAlias:callbackSelector:object:")]
		void SetAlias (string alias, [NullAllowed]Selector cbSelector, [NullAllowed]NSObject theTarget);

		// +(NSSet *)filterValidTags:(NSSet *)tags;
		[Static]
		[Export ("filterValidTags:")]
		NSSet FilterValidTags (NSSet tags);

		// +(void)startLogPageView:(NSString *)pageName;
		[Static]
		[Export ("startLogPageView:")]
		void StartLogPageView (string pageName);

		// +(void)stopLogPageView:(NSString *)pageName;
		[Static]
		[Export ("stopLogPageView:")]
		void StopLogPageView (string pageName);

		// +(void)beginLogPageView:(NSString *)pageName duration:(int)seconds;
		[Static]
		[Export ("beginLogPageView:duration:")]
		void BeginLogPageView (string pageName, int seconds);

		// +(void)crashLogON;
		[Static]
		[Export ("crashLogON")]
		void CrashLogON ();

		// +(void)setLatitude:(double)latitude longitude:(double)longitude;
		[Static]
		[Export ("setLatitude:longitude:")]
		void SetLatitude (double latitude, double longitude);

		// +(void)setLocation:(CLLocation *)location;
		[Static]
		[Export ("setLocation:")]
		void SetLocation (CLLocation location);

		// +(UILocalNotification *)setLocalNotification:(NSDate *)fireDate alertBody:(NSString *)alertBody badge:(int)badge alertAction:(NSString *)alertAction identifierKey:(NSString *)notificationKey userInfo:(NSDictionary *)userInfo soundName:(NSString *)soundName;
		[Static]
		[Export ("setLocalNotification:alertBody:badge:alertAction:identifierKey:userInfo:soundName:")]
		UILocalNotification SetLocalNotification (NSDate fireDate, string alertBody, int badge, string alertAction, string notificationKey, NSDictionary userInfo, string soundName);

		// +(UILocalNotification *)setLocalNotification:(NSDate *)fireDate alertBody:(NSString *)alertBody badge:(int)badge alertAction:(NSString *)alertAction identifierKey:(NSString *)notificationKey userInfo:(NSDictionary *)userInfo soundName:(NSString *)soundName region:(CLRegion *)region regionTriggersOnce:(BOOL)regionTriggersOnce category:(NSString *)category __attribute__((availability(ios, introduced=8_0)));
		//[iOS (8, 0)]
		[Static]
		[Export ("setLocalNotification:alertBody:badge:alertAction:identifierKey:userInfo:soundName:region:regionTriggersOnce:category:")]
		UILocalNotification SetLocalNotification (NSDate fireDate, string alertBody, int badge, string alertAction, string notificationKey, NSDictionary userInfo, string soundName, CLRegion region, bool regionTriggersOnce, string category);

		// +(void)showLocalNotificationAtFront:(UILocalNotification *)notification identifierKey:(NSString *)notificationKey;
		[Static]
		[Export ("showLocalNotificationAtFront:identifierKey:")]
		void ShowLocalNotificationAtFront (UILocalNotification notification, string notificationKey);

		// +(void)deleteLocalNotificationWithIdentifierKey:(NSString *)notificationKey;
		[Static]
		[Export ("deleteLocalNotificationWithIdentifierKey:")]
		void DeleteLocalNotificationWithIdentifierKey (string notificationKey);

		// +(void)deleteLocalNotification:(UILocalNotification *)localNotification;
		[Static]
		[Export ("deleteLocalNotification:")]
		void DeleteLocalNotification (UILocalNotification localNotification);

		// +(NSArray *)findLocalNotificationWithIdentifier:(NSString *)notificationKey;
		[Static]
		[Export ("findLocalNotificationWithIdentifier:")]
		//[Verify (StronglyTypedNSArray)]
		NSObject [] FindLocalNotificationWithIdentifier (string notificationKey);

		// +(void)clearAllLocalNotifications;
		[Static]
		[Export ("clearAllLocalNotifications")]
		void ClearAllLocalNotifications ();

		// +(BOOL)setBadge:(NSInteger)value;
		[Static]
		[Export ("setBadge:")]
		bool SetBadge (nint value);

		// +(void)resetBadge;
		[Static]
		[Export ("resetBadge")]
		void ResetBadge ();

		// +(NSString *)registrationID;
		[Static]
		[Export ("registrationID")]
		//[Verify (MethodToProperty)]
		string RegistrationID { get; }

		// +(void)setDebugMode;
		[Static]
		[Export ("setDebugMode")]
		void SetDebugMode ();

		// +(void)setLogOFF;
		[Static]
		[Export ("setLogOFF")]
		void SetLogOFF ();
	}
}

