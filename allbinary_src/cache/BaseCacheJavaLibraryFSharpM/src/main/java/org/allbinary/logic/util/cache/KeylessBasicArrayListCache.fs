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
type KeylessBasicArrayListCache =
    inherit IndexedBasicArrayListCache
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable basicArrayListUtil : BasicArrayListUtil
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not KeylessBasicArrayListCache.jclinitDone then
            KeylessBasicArrayListCache.jclinitDone <- true
            KeylessBasicArrayListCache.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_KeylessBasicArrayListCache() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.basicArrayListUtil <- BasicArrayListUtil.getInstance()
        ()
    
    new () as this =
        { inherit IndexedBasicArrayListCache() }
        then
            this.jfields_KeylessBasicArrayListCache()
    
    abstract get : unit -> BasicArrayList
    default this.get() : BasicArrayList =
        let mutable jflow = 0
        let mutable jret : BasicArrayList = Unchecked.defaultof<BasicArrayList>
        try
            if this.index >= this.list.size() then
                this.addDefault()
            let mutable list_ : BasicArrayList = (box (this.getAt((let jt = this.index in this.index <- this.index + 1; jt))) :?> BasicArrayList)
            jret <- list_
            jflow <- 1
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                this.logUtil.put(this.commonStrings.EXCEPTION, this, this.commonStrings.GET, e)
                jret <- this.basicArrayListUtil.getImmutableInstance()
                jflow <- 1
            | _ -> reraise ()
        jret
    
    override this.clear() : unit =
        base.clear()
        let mutable basicArrayList : BasicArrayList = null
        let mutable index : int = this.list.size() - 1
        while index >= 0 do
            basicArrayList <- ((box (this.list.objectArray.[index]) :?> BasicArrayList))
            basicArrayList.clear()
            index <- index - 1
    
    override this.log() : string =
        let mutable stringBuffer : StringMaker = (new StringMaker())
        ignore (stringBuffer.append("S: "))
        ignore (stringBuffer.appendint(this.list.size()))
        let mutable S_LABEL : string = " s: "
        let mutable basicArrayList : BasicArrayList = null
        let mutable index : int = this.list.size() - 1
        while index >= 0 do
            ignore (stringBuffer.append(S_LABEL))
            basicArrayList <- ((box (this.list.objectArray.[index]) :?> BasicArrayList))
            ignore (stringBuffer.appendint(basicArrayList.size()))
            index <- index - 1
        stringBuffer.ToString()


