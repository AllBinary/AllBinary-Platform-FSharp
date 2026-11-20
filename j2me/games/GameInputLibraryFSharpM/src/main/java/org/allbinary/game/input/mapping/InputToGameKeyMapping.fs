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
type InputToGameKeyMapping =
    inherit InputMapping
    [<DefaultValue(false)>] val mutable gameKeyFactory : GameKeyFactory
    [<DefaultValue(false)>] val mutable mappedGameKeys : GameKey[]
    [<DefaultValue(false)>] val mutable platformToGameKeyMapping : GameKey[]
    [<DefaultValue(false)>] val mutable negativePlatformToGameKeyMapping : GameKey[]
    [<DefaultValue(false)>] static val mutable private jcell_instance : obj
    static member instance with get() : obj = (InputToGameKeyMapping.jclinit(); InputToGameKeyMapping.jcell_instance) and set (jvalue: obj) = (InputToGameKeyMapping.jclinit(); InputToGameKeyMapping.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not InputToGameKeyMapping.jclinitDone then
            InputToGameKeyMapping.jclinitDone <- true
            InputToGameKeyMapping.jclinitBody()
    static member private jclinitBody() : unit =
        InputToGameKeyMapping.jcell_instance <- NullUtil.getInstance().NULL_OBJECT
        ()
    member this.jfields_InputToGameKeyMapping() : unit =
        this.gameKeyFactory <- GameKeyFactory.getInstance()
        this.mappedGameKeys <- ([| this.gameKeyFactory.UP; this.gameKeyFactory.DOWN; this.gameKeyFactory.LEFT; this.gameKeyFactory.RIGHT |] : GameKey[])
        this.platformToGameKeyMapping <- (Array.zeroCreate<GameKey> (InputFactory.getInstance().MAX))
        this.negativePlatformToGameKeyMapping <- (Array.zeroCreate<GameKey> (0))
        ()
    
    static member getNullInstance() : InputToGameKeyMapping =
        if (JR.same(InputToGameKeyMapping.instance, NullUtil.getInstance().NULL_OBJECT)) then
            InputToGameKeyMapping.instance <- (new InputToGameKeyMapping())
        (box (InputToGameKeyMapping.instance) :?> InputToGameKeyMapping)
    
    new () as this =
        { inherit InputMapping() }
        then
            this.jfields_InputToGameKeyMapping()
            this.jctor1()
    member this.jctor1() : unit =
        this.logUtil.putF(this.commonStrings.START, this, this.commonStrings.CONSTRUCTOR)
        this.clear()
        ()
    
    member this.clear() : unit =
        let mutable index : int = this.platformToGameKeyMapping.Length - 1
        while index >= 0 do
            this.platformToGameKeyMapping.[index] <- this.gameKeyFactory.NONE
            index <- index - 1
    
    override this.removeAll() : unit =
        base.removeAll()
        this.clear()
    
    override this.addMapping(inputToGameKeyMapping: InputToGameKeyMapping) : unit =
        let mutable index : int = inputToGameKeyMapping.getMaxMappable() - 1
        while index >= 0 do
            let mutable input : Input = inputToGameKeyMapping.getInstance(index)
            if not (JR.same(input, this.gameKeyFactory.NONE)) then
                this.addAll(input, inputToGameKeyMapping.getMappedInput(input))
            index <- index - 1
    
    member this.addAll(input: Input, list_: BasicArrayList) : unit =
        let mutable index : int = list_.size() - 1
        while index >= 0 do
            let mutable mappedToInput : Input = (box (list_.objectArray.[index]) :?> Input)
            this.add(input, mappedToInput)
            index <- index - 1
    
    override this.add(input: Input, mappedToInput: Input) : unit =
        base.add(input, mappedToInput)
        this.set(input, mappedToInput)
    
    override this.remove(input: Input, mappedToInput: Input) : unit =
        this.logUtil.putF((new StringMaker()).append(CommonLabels.getInstance().START_LABEL).append(StringUtil.getInstance().toString(input)).append(" == ").append(StringUtil.getInstance().toString(mappedToInput)).ToString(), this, "InputToGameKeyMapping::remove")
        base.remove(input, mappedToInput)
        this.set(input, this.gameKeyFactory.NONE)
    
    member this.set(input: Input, mappedToInput: Input) : unit =
        let mutable id_ : int = mappedToInput.getId()
        if (id_ >= 0) && (id_ < this.platformToGameKeyMapping.Length) then
            this.platformToGameKeyMapping.[id_] <- (box (input) :?> GameKey)
    
    abstract getMaxMappable : unit -> int
    default this.getMaxMappable() : int =
        this.platformToGameKeyMapping.Length
    
    abstract getReverseInstance : id_: int -> BasicArrayList
    default this.getReverseInstance(id_: int) : BasicArrayList =
        let mutable list_ : BasicArrayList = (new BasicArrayListD())
        let mutable inputFactory : InputFactory = InputFactory.getInstance()
        let mutable index : int = 0
        while index < this.platformToGameKeyMapping.Length do
            if this.platformToGameKeyMapping.[index].getId() = id_ then
                let mutable input : Input = inputFactory.getInstanceById(index)
                if not (JR.same(input, null)) then
                    ignore (list_.add(input))
            index <- index + 1
        list_
    
    member this.initGameKey(canvas: Canvas, gameKey: GameKey) : unit =
        let mutable key : int = canvas.getKeyCode(gameKey.getId())
        if (key < 0) && ((-(key)) < this.negativePlatformToGameKeyMapping.Length) then
            this.negativePlatformToGameKeyMapping.[-(key)] <- gameKey
        elif key > 0 then
            if (JR.same(this.platformToGameKeyMapping.[key], this.gameKeyFactory.NONE)) then
                this.platformToGameKeyMapping.[key] <- gameKey
        else
            PreLogUtil.putOE((new StringMaker()).append(gameKey.ToString()).append(CommonSeps.getInstance().COLON_SEP).appendint(key).ToString(), this, this.commonStrings.INIT, (new JException()))
    
    member this.getSmallestCanvasGameKeyCode(canvas: Canvas) : int =
        let mutable nextKey : int = 0
        let mutable smallestKey : int = 0
        let mutable index : int = this.mappedGameKeys.Length
        while ((index <- index - 1; index)) >= 0 do
            nextKey <- canvas.getKeyCode(this.mappedGameKeys.[index].getId())
            if nextKey < smallestKey then
                smallestKey <- nextKey
        smallestKey
    
    abstract init : canvas: Canvas -> unit
    default this.init(canvas: Canvas) : unit =
        try
            let mutable negativePlatformToGameKeyMapping : GameKey[] = (Array.zeroCreate<GameKey> (0))
            let mutable smallestKey : int = this.getSmallestCanvasGameKeyCode(canvas)
            if smallestKey < 0 then
                smallestKey <- smallestKey - 1
                if smallestKey < (-256) then
                    smallestKey <- -256
                negativePlatformToGameKeyMapping <- (Array.zeroCreate<GameKey> (-(smallestKey)))
                let mutable index : int = negativePlatformToGameKeyMapping.Length
                while ((index <- index - 1; index)) >= 0 do
                    negativePlatformToGameKeyMapping.[index] <- this.gameKeyFactory.NONE
                this.negativePlatformToGameKeyMapping <- negativePlatformToGameKeyMapping
            let mutable index : int = this.mappedGameKeys.Length
            while ((index <- index - 1; index)) >= 0 do
                this.initGameKey(canvas, this.mappedGameKeys.[index])
        with jex ->
            match JR.throwable(jex) with
            | :? JThrowable as t ->
                this.logUtil.put(this.commonStrings.EXCEPTION, this, this.commonStrings.INIT, t)
            | _ -> reraise ()
    
    abstract getInstanceForCanvas : canvas: Canvas * id_: int -> GameKey
    default this.getInstanceForCanvas(canvas: Canvas, id_: int) : GameKey =
        let mutable jflow = 0
        let mutable jret : GameKey = Unchecked.defaultof<GameKey>
        if (id_ >= 0) && (id_ < this.platformToGameKeyMapping.Length) then
            jret <- this.platformToGameKeyMapping.[id_]
            jflow <- 1
        elif (id_ < 0) && ((-(id_)) < this.negativePlatformToGameKeyMapping.Length) then
            jret <- this.negativePlatformToGameKeyMapping.[-(id_)]
            jflow <- 1
        else
            jret <- this.gameKeyFactory.NONE
            jflow <- 1
        jret
    
    abstract getInstance : id_: int -> GameKey
    default this.getInstance(id_: int) : GameKey =
        let mutable jflow = 0
        let mutable jret : GameKey = Unchecked.defaultof<GameKey>
        if (id_ >= 0) && (id_ < this.platformToGameKeyMapping.Length) then
            jret <- this.platformToGameKeyMapping.[id_]
            jflow <- 1
        elif (id_ < 0) && ((-(id_)) < this.negativePlatformToGameKeyMapping.Length) then
            jret <- this.negativePlatformToGameKeyMapping.[-(id_)]
            jflow <- 1
        else
            jret <- this.gameKeyFactory.NONE
            jflow <- 1
        jret


