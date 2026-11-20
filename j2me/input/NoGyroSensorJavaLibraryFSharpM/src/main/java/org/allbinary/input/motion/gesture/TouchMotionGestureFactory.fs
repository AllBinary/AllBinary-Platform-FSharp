namespace rec AllBinary

// Generated Code Do Not Modify
(*
 *
 * AllBinary Open License Version 1
 * Copyright (c) 2011 AllBinary
 * 
 * By agreeing to this license you and any business entity you represent are
 * legally bound to the AllBinary Open License Version 1 legal agreement.
 * 
 * You may obtain the AllBinary Open License Version 1 legal agreement from
 * AllBinary or the root directory of AllBinary's AllBinary Platform repository.
 * 
 * Created By: Travis Berthelot
 *  
 *)

[<AllowNullLiteral>]
type TouchMotionGestureFactory =
    [<DefaultValue(false)>] val mutable LEFT : MotionGestureInput
    [<DefaultValue(false)>] val mutable RIGHT : MotionGestureInput
    [<DefaultValue(false)>] val mutable UP : MotionGestureInput
    [<DefaultValue(false)>] val mutable DOWN : MotionGestureInput
    [<DefaultValue(false)>] val mutable PRESSED : MotionGestureInput
    [<DefaultValue(false)>] val mutable RELEASED : MotionGestureInput
    [<DefaultValue(false)>] val mutable DIAGONAL_DOWN_RIGHT : MotionGestureInput
    [<DefaultValue(false)>] val mutable DIAGONAL_DOWN_LEFT : MotionGestureInput
    [<DefaultValue(false)>] val mutable DIAGONAL_UP_RIGHT : MotionGestureInput
    [<DefaultValue(false)>] val mutable DIAGONAL_UP_LEFT : MotionGestureInput
    [<DefaultValue(false)>] val mutable SCROLL_UP : MotionGestureInput
    [<DefaultValue(false)>] val mutable SCROLL_DOWN : MotionGestureInput
    [<DefaultValue(false)>] val mutable NO_MOTION : MotionGestureInput
    [<DefaultValue(false)>] val mutable LAST_MOTION : MotionGestureInput
    [<DefaultValue(false)>] static val mutable private jcell_instance : obj
    static member instance with get() : obj = (TouchMotionGestureFactory.jclinit(); TouchMotionGestureFactory.jcell_instance) and set (jvalue: obj) = (TouchMotionGestureFactory.jclinit(); TouchMotionGestureFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not TouchMotionGestureFactory.jclinitDone then
            TouchMotionGestureFactory.jclinitDone <- true
            TouchMotionGestureFactory.jclinitBody()
    static member private jclinitBody() : unit =
        TouchMotionGestureFactory.jcell_instance <- NullUtil.getInstance().NULL_OBJECT
        ()
    
    static member getInstance() : TouchMotionGestureFactory =
        if (JR.same(TouchMotionGestureFactory.instance, NullUtil.getInstance().NULL_OBJECT)) then
            TouchMotionGestureFactory.instance <- (new TouchMotionGestureFactory())
        (box (TouchMotionGestureFactory.instance) :?> TouchMotionGestureFactory)
    
    new () as this =
        {  }
        then
            this.jctor1()
    member this.jctor1() : unit =
        let mutable MAX : int = InputFactory.getInstance().MAX
        this.LEFT <- (new MotionGestureInput((MAX - 3), "Left Touch"))
        this.RIGHT <- (new MotionGestureInput((MAX - 4), "Right Touch"))
        this.UP <- (new MotionGestureInput((MAX - 5), "Up Touch"))
        this.DOWN <- (new MotionGestureInput((MAX - 6), "Down Touch"))
        this.PRESSED <- (new MotionGestureInput((MAX - 7), "Screen Press"))
        this.RELEASED <- (new MotionGestureInput((MAX - 8), "Released"))
        this.DIAGONAL_DOWN_RIGHT <- (new MotionGestureInput((MAX - 9), "Diagonal Dn R"))
        this.DIAGONAL_DOWN_LEFT <- (new MotionGestureInput((MAX - 10), "Diagonal Dn L"))
        this.DIAGONAL_UP_RIGHT <- (new MotionGestureInput((MAX - 11), "Diagonal Up R"))
        this.DIAGONAL_UP_LEFT <- (new MotionGestureInput((MAX - 12), "Diagonal Up L"))
        this.SCROLL_UP <- (new MotionGestureInput((MAX - 13), "Scroll Up"))
        this.SCROLL_DOWN <- (new MotionGestureInput((MAX - 14), "Scroll Down"))
        this.NO_MOTION <- (new MotionGestureInput((MAX - 2), "No Motion"))
        this.LAST_MOTION <- (new MotionGestureInput((MAX - 19), "Last Motion"))
        ()


