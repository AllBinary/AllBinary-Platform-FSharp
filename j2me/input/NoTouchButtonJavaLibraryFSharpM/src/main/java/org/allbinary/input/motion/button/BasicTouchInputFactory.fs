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
type BasicTouchInputFactory =
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable SPECIAL_BUTTON_SIX : TouchButtonInput
    [<DefaultValue(false)>] val mutable SPECIAL_BUTTON_FIVE : TouchButtonInput
    [<DefaultValue(false)>] val mutable SPECIAL_BUTTON_FOUR : TouchButtonInput
    [<DefaultValue(false)>] val mutable SPECIAL_BUTTON_THREE : TouchButtonInput
    [<DefaultValue(false)>] val mutable SPECIAL_BUTTON_TWO : TouchButtonInput
    [<DefaultValue(false)>] val mutable SPECIAL_BUTTON_ONE : TouchButtonInput
    [<DefaultValue(false)>] val mutable UP : TouchButtonInput
    [<DefaultValue(false)>] val mutable LEFT : TouchButtonInput
    [<DefaultValue(false)>] val mutable RIGHT : TouchButtonInput
    [<DefaultValue(false)>] val mutable DOWN : TouchButtonInput
    [<DefaultValue(false)>] val mutable NONE : TouchButtonInput
    [<DefaultValue(false)>] val mutable initialized : bool
    [<DefaultValue(false)>] val mutable list : BasicArrayList
    [<DefaultValue(false)>] static val mutable private jcell_instance : obj
    static member instance with get() : obj = (BasicTouchInputFactory.jclinit(); BasicTouchInputFactory.jcell_instance) and set (jvalue: obj) = (BasicTouchInputFactory.jclinit(); BasicTouchInputFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not BasicTouchInputFactory.jclinitDone then
            BasicTouchInputFactory.jclinitDone <- true
            BasicTouchInputFactory.jclinitBody()
    static member private jclinitBody() : unit =
        BasicTouchInputFactory.jcell_instance <- NullUtil.getInstance().NULL_OBJECT
        ()
    new () as this =
        {  }
        then
            this.jfields_BasicTouchInputFactory()
    member this.jfields_BasicTouchInputFactory() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.SPECIAL_BUTTON_SIX <- (new TouchButtonInput((InputFactory.getInstance().MAX - 30), "Button 6"))
        this.SPECIAL_BUTTON_FIVE <- (new TouchButtonInput((InputFactory.getInstance().MAX - 31), "Button 5"))
        this.SPECIAL_BUTTON_FOUR <- (new TouchButtonInput((InputFactory.getInstance().MAX - 32), "Button 4"))
        this.SPECIAL_BUTTON_THREE <- (new TouchButtonInput((InputFactory.getInstance().MAX - 33), "Button 3"))
        this.SPECIAL_BUTTON_TWO <- (new TouchButtonInput((InputFactory.getInstance().MAX - 34), "Button 2"))
        this.SPECIAL_BUTTON_ONE <- (new TouchButtonInput((InputFactory.getInstance().MAX - 35), "Button 1"))
        this.UP <- (new TouchButtonInput((InputFactory.getInstance().MAX - 36), "Up Button"))
        this.LEFT <- (new TouchButtonInput((InputFactory.getInstance().MAX - 37), "Left Button"))
        this.RIGHT <- (new TouchButtonInput((InputFactory.getInstance().MAX - 38), "Right Button"))
        this.DOWN <- (new TouchButtonInput((InputFactory.getInstance().MAX - 39), "Down Button"))
        this.NONE <- (new TouchButtonInput((InputFactory.getInstance().MAX - 40), "No Button"))
        this.initialized <- false
        this.list <- (new BasicArrayListD())
        ()
    
    static member getInstance() : BasicTouchInputFactory =
        if (JR.same(BasicTouchInputFactory.instance, NullUtil.getInstance().NULL_OBJECT)) then
            BasicTouchInputFactory.instance <- (new BasicTouchInputFactory())
        (box (BasicTouchInputFactory.instance) :?> BasicTouchInputFactory)
    
    abstract init : inputToGameKeyMapping: InputToGameKeyMapping -> unit
    default this.init(inputToGameKeyMapping: InputToGameKeyMapping) : unit =
        if not (this.initialized) then
            this.initialized <- true
            ignore (this.list.add(this.UP))
            ignore (this.list.add(this.LEFT))
            ignore (this.list.add(this.RIGHT))
            ignore (this.list.add(this.DOWN))
            ignore (this.list.add(this.SPECIAL_BUTTON_TWO))
            ignore (this.list.add(this.SPECIAL_BUTTON_FOUR))
            ignore (this.list.add(this.SPECIAL_BUTTON_THREE))
            ignore (this.list.add(this.SPECIAL_BUTTON_ONE))
            ignore (this.list.add(this.SPECIAL_BUTTON_FIVE))
            ignore (this.list.add(this.SPECIAL_BUTTON_SIX))
            this.updateAllList(this.list, inputToGameKeyMapping)
    
    abstract updateAll : inputToGameKeyMapping: InputToGameKeyMapping -> unit
    default this.updateAll(inputToGameKeyMapping: InputToGameKeyMapping) : unit =
        this.updateAllList(this.getList(), inputToGameKeyMapping)
    
    abstract updateAllList : list_: BasicArrayList * inputToGameKeyMapping: InputToGameKeyMapping -> unit
    default this.updateAllList(list_: BasicArrayList, inputToGameKeyMapping: InputToGameKeyMapping) : unit =
        this.logUtil.putF((new StringMaker()).append(CommonLabels.getInstance().START).appendint(list_.size()).ToString(), this, "updateAll")
        let mutable index : int = list_.size() - 1
        while index >= 0 do
            let mutable touchButtonInput : TouchButtonInput = (box (list_.get(index)) :?> TouchButtonInput)
            touchButtonInput.update(inputToGameKeyMapping)
            index <- index - 1
    
    abstract getList : unit -> BasicArrayList
    default this.getList() : BasicArrayList =
        this.list


