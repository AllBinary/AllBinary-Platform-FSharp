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
type BasicArrayListUtil =
    [<DefaultValue(false)>] val mutable NULL_ARRAY_OF_ARRAY : BasicArrayList[][]
    [<DefaultValue(false)>] val mutable myRandomFactory : MyRandomFactory
    [<DefaultValue(false)>] val mutable immutableInstance : BasicArrayList
    [<DefaultValue(false)>] static val mutable private jcell_instance : BasicArrayListUtil
    static member instance with get() : BasicArrayListUtil = (BasicArrayListUtil.jclinit(); BasicArrayListUtil.jcell_instance) and set (jvalue: BasicArrayListUtil) = (BasicArrayListUtil.jclinit(); BasicArrayListUtil.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not BasicArrayListUtil.jclinitDone then
            BasicArrayListUtil.jclinitDone <- true
            BasicArrayListUtil.jclinitBody()
    static member private jclinitBody() : unit =
        BasicArrayListUtil.jcell_instance <- (new BasicArrayListUtil())
        ()
    new () as this =
        {  }
        then
            this.jfields_BasicArrayListUtil()
    member this.jfields_BasicArrayListUtil() : unit =
        this.NULL_ARRAY_OF_ARRAY <- (JR.newArray2<BasicArrayList>(0, 0))
        this.myRandomFactory <- MyRandomFactory.getInstance()
        this.immutableInstance <- (new ImmutableBasicArrayList("Immutable", 0))
        ()
    
    static member getInstance() : BasicArrayListUtil =
        BasicArrayListUtil.instance
    
    abstract getRandom : list_: BasicArrayList -> obj
    default this.getRandom(list_: BasicArrayList) : obj =
        let mutable i_random : int = this.getRandomIndex(list_)
        list_.objectArray.[i_random]
    
    abstract getRandomIndex : list_: BasicArrayList -> int
    default this.getRandomIndex(list_: BasicArrayList) : int =
        this.myRandomFactory.getAbsoluteNextInt(list_.size())
    
    abstract reverse : list_: BasicArrayList -> unit
    default this.reverse(list_: BasicArrayList) : unit =
        let mutable lastMinusOneIndex : int = list_.size() - 2
        let mutable temp : obj = null
        let mutable size : int = lastMinusOneIndex / 2
        let mutable secondSwapIndex : int = 0
        let mutable index : int = 0
        while index <= size do
            secondSwapIndex <- lastMinusOneIndex - index
            temp <- list_.removeAt(index)
            list_.addAt(index, list_.removeAt(secondSwapIndex))
            list_.addAt((secondSwapIndex + 1), temp)
            index <- index + 1
    
    abstract log : list_: BasicArrayList -> string
    default this.log(list_: BasicArrayList) : string =
        let mutable S_LABEL : string = " s: "
        let mutable size : int = list_.size()
        let mutable stringBuffer : StringMaker = (new StringMaker())
        ignore (stringBuffer.append(CommonLabels.getInstance().TOTAL_LABEL))
        ignore (stringBuffer.appendint(size))
        let mutable index : int = size - 1
        while index >= 0 do
            let mutable usedList : BasicArrayList = (box (list_.objectArray.[index]) :?> BasicArrayList)
            ignore (stringBuffer.append(S_LABEL))
            ignore (stringBuffer.appendint(usedList.size()))
            index <- index - 1
        stringBuffer.ToString()
    
    abstract getImmutableInstance : unit -> BasicArrayList
    default this.getImmutableInstance() : BasicArrayList =
        this.immutableInstance
    
    static member main(args: string[]) : unit =
        let mutable commonPhoneStrings : CommonPhoneStrings = CommonPhoneStrings.getInstance()
        let mutable list_ : BasicArrayList = (new BasicArrayListD())
        ignore (list_.add(commonPhoneStrings.ONE))
        ignore (list_.add(commonPhoneStrings.TWO))
        ignore (list_.add(commonPhoneStrings.THREE))
        ignore (list_.add(commonPhoneStrings.FOUR))
        ignore (list_.add(commonPhoneStrings.FIVE))
        ignore (list_.add(commonPhoneStrings.SIX))
        ignore (list_.add(commonPhoneStrings.SEVEN))
        ignore (list_.add(commonPhoneStrings.EIGHT))
        ignore (list_.add(commonPhoneStrings.NINE))
        BasicArrayListUtil.getInstance().reverse(list_)
        JSystem.out.println(list_.ToString())


