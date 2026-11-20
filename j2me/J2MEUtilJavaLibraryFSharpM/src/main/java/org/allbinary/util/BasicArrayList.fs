namespace rec AllBinary

// Generated Code Do Not Modify

[<AllowNullLiteral>]
type BasicArrayList =
    [<DefaultValue(false)>] val mutable arrayUtil : ArrayUtil
    [<DefaultValue(false)>] val mutable objectArray : obj[]
    [<DefaultValue(false)>] val mutable currentIndex : int
    static member SIZE : string = ", Size: "
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not BasicArrayList.jclinitDone then
            BasicArrayList.jclinitDone <- true
            BasicArrayList.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_BasicArrayList() : unit =
        this.arrayUtil <- ArrayUtil.getInstance()
        this.currentIndex <- 0
        ()
    
    new (objectArray: obj[]) as this =
        {  }
        then
            this.jfields_BasicArrayList()
            this.jctor1(objectArray)
    member this.jctor1(objectArray: obj[]) : unit =
        this.objectArray <- objectArray
        ()
    
    abstract addAt : index: int * element: obj -> unit
    default this.addAt(index: int, element: obj) : unit =
        if (index > this.currentIndex) || (index < 0) then
            let mutable stringBuffer : StringMaker = (new StringMaker())
            ignore (stringBuffer.append(CommonLabels.getInstance().INDEX_LABEL))
            ignore (stringBuffer.appendint(index))
            ignore (stringBuffer.append(BasicArrayList.SIZE))
            ignore (stringBuffer.appendint(this.currentIndex))
            raise ((new JIndexOutOfBoundsException(stringBuffer.ToString())))
        this.ensureCapacity((this.currentIndex + 1))
        ignore (JSystem.arraycopy(this.objectArray, index, this.objectArray, (index + 1), (this.currentIndex - index)))
        this.objectArray.[index] <- element
        this.currentIndex <- this.currentIndex + 1
    
    abstract add : anyType: obj -> bool
    default this.add(anyType: obj) : bool =
        this.ensureCapacity((this.currentIndex + 1))
        this.objectArray.[(let jt = this.currentIndex in this.currentIndex <- this.currentIndex + 1; jt)] <- anyType
        true
    
    abstract removeAt : index: int -> obj
    default this.removeAt(index: int) : obj =
        if index >= this.currentIndex then
            let mutable stringBuffer : StringMaker = (new StringMaker())
            ignore (stringBuffer.append(CommonLabels.getInstance().INDEX_LABEL))
            ignore (stringBuffer.appendint(index))
            ignore (stringBuffer.append(BasicArrayList.SIZE))
            ignore (stringBuffer.appendint(this.currentIndex))
            raise ((new JIndexOutOfBoundsException(stringBuffer.ToString())))
        let mutable oldValue : obj = this.objectArray.[index]
        let mutable numMoved : int = (this.currentIndex - index) - 1
        if numMoved > 0 then
            ignore (JSystem.arraycopy(this.objectArray, (index + 1), this.objectArray, index, numMoved))
        this.objectArray.[(this.currentIndex <- this.currentIndex - 1; this.currentIndex)] <- null
        oldValue
    
    abstract remove : anyType: obj -> bool
    default this.remove(anyType: obj) : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        if (JR.same(anyType, null)) then
            let mutable index : int = 0
            while jflow = 0 && (index < this.currentIndex) do
                if (JR.same(this.objectArray.[index], null)) then
                    let mutable numMoved : int = (this.currentIndex - index) - 1
                    if numMoved > 0 then
                        ignore (JSystem.arraycopy(this.objectArray, (index + 1), this.objectArray, index, numMoved))
                    this.objectArray.[(this.currentIndex <- this.currentIndex - 1; this.currentIndex)] <- null
                    jret <- true
                    jflow <- 1
                if jflow = 200002 then jflow <- 0
                if jflow = 0 then index <- index + 1
            if jflow = 100002 then jflow <- 0
        else
            let mutable index : int = 0
            while jflow = 0 && (index < this.currentIndex) do
                if ((JR.same(anyType, this.objectArray.[index]))) || JR.equals(anyType, this.objectArray.[index]) then
                    let mutable numMoved : int = (this.currentIndex - index) - 1
                    if numMoved > 0 then
                        ignore (JSystem.arraycopy(this.objectArray, (index + 1), this.objectArray, index, numMoved))
                    this.objectArray.[(this.currentIndex <- this.currentIndex - 1; this.currentIndex)] <- null
                    jret <- true
                    jflow <- 1
                if jflow = 200001 then jflow <- 0
                if jflow = 0 then index <- index + 1
            if jflow = 100001 then jflow <- 0
        if jflow = 0 then
            jret <- false
            jflow <- 1
        jret
    
    abstract removeAll2 : list_: BasicArrayList -> bool
    default this.removeAll2(list_: BasicArrayList) : bool =
        let mutable result : bool = true
        let mutable size : int = list_.size()
        let mutable index : int = 0
        while index < size do
            if this.remove(list_.get(index)) then
                ()
            else
                result <- false
            index <- index + 1
        result
    
    abstract addAll2 : list_: BasicArrayList -> bool
    default this.addAll2(list_: BasicArrayList) : bool =
        this.ensureCapacity((this.currentIndex + list_.currentIndex))
        let mutable listSize : int = list_.currentIndex
        let mutable index : int = 0
        while index < listSize do
            this.objectArray.[(let jt = this.currentIndex in this.currentIndex <- this.currentIndex + 1; jt)] <- list_.objectArray.[index]
            index <- index + 1
        true
    
    abstract addAllList : list_: BasicArrayList -> bool
    default this.addAllList(list_: BasicArrayList) : bool =
        let mutable newObjectArray : obj[] = list_.toArray()
        this.addAll(newObjectArray)
    
    abstract addAll : newObjectArray: obj[] -> bool
    default this.addAll(newObjectArray: obj[]) : bool =
        let mutable numSize : int = newObjectArray.Length
        this.ensureCapacity((this.currentIndex + numSize))
        ignore (JSystem.arraycopy(newObjectArray, 0, this.objectArray, this.currentIndex, numSize))
        this.currentIndex <- this.currentIndex + numSize
        numSize <> 0
    
    abstract ensureCapacity : minSize: int -> unit
    default this.ensureCapacity(minSize: int) : unit =
        let mutable oldCapacity : int = this.objectArray.Length
        if minSize > oldCapacity then
            let mutable newCapacity : int = ((oldCapacity * 3) >>> 1) + 1
            if newCapacity < minSize then
                newCapacity <- minSize
            this.objectArray <- this.arrayUtil.copyOf(this.objectArray, newCapacity)
    
    abstract trimToSize : unit -> unit
    default this.trimToSize() : unit =
        let mutable oldCapacity : int = this.objectArray.Length
        if this.currentIndex < oldCapacity then
            this.objectArray <- this.arrayUtil.copyOf(this.objectArray, this.currentIndex)
    
    abstract indexOf : anyType: obj -> int
    default this.indexOf(anyType: obj) : int =
        let mutable jflow = 0
        let mutable jret : int = Unchecked.defaultof<int>
        if (JR.same(anyType, null)) then
            let mutable i : int = 0
            while jflow = 0 && (i < this.currentIndex) do
                if (JR.same(this.objectArray.[i], null)) then
                    jret <- i
                    jflow <- 1
                if jflow = 200006 then jflow <- 0
                if jflow = 0 then i <- i + 1
            if jflow = 100006 then jflow <- 0
        else
            let mutable i : int = 0
            while jflow = 0 && (i < this.currentIndex) do
                if JR.equals(anyType, this.objectArray.[i]) then
                    jret <- i
                    jflow <- 1
                if jflow = 200005 then jflow <- 0
                if jflow = 0 then i <- i + 1
            if jflow = 100005 then jflow <- 0
        if jflow = 0 then
            jret <- -1
            jflow <- 1
        jret
    
    abstract lastIndexOf : anyType: obj -> int
    default this.lastIndexOf(anyType: obj) : int =
        let mutable jflow = 0
        let mutable jret : int = Unchecked.defaultof<int>
        if (JR.same(anyType, null)) then
            let mutable i : int = this.currentIndex - 1
            while jflow = 0 && (i >= 0) do
                if (JR.same(this.objectArray.[i], null)) then
                    jret <- i
                    jflow <- 1
                if jflow = 200008 then jflow <- 0
                if jflow = 0 then i <- i - 1
            if jflow = 100008 then jflow <- 0
        else
            let mutable i : int = this.currentIndex - 1
            while jflow = 0 && (i >= 0) do
                if JR.equals(anyType, this.objectArray.[i]) then
                    jret <- i
                    jflow <- 1
                if jflow = 200007 then jflow <- 0
                if jflow = 0 then i <- i - 1
            if jflow = 100007 then jflow <- 0
        if jflow = 0 then
            jret <- -1
            jflow <- 1
        jret
    
    abstract get : index: int -> obj
    default this.get(index: int) : obj =
        if index >= this.currentIndex then
            let mutable stringBuffer : StringMaker = (new StringMaker())
            ignore (stringBuffer.append(CommonLabels.getInstance().INDEX_LABEL))
            ignore (stringBuffer.appendint(index))
            ignore (stringBuffer.append(BasicArrayList.SIZE))
            ignore (stringBuffer.appendint(this.currentIndex))
            raise ((new JIndexOutOfBoundsException(stringBuffer.ToString())))
        this.objectArray.[index]
    
    abstract set : index: int * element: obj -> obj
    default this.set(index: int, element: obj) : obj =
        if index >= this.currentIndex then
            let mutable stringBuffer : StringMaker = (new StringMaker())
            ignore (stringBuffer.append(CommonLabels.getInstance().INDEX_LABEL))
            ignore (stringBuffer.appendint(index))
            ignore (stringBuffer.append(BasicArrayList.SIZE))
            ignore (stringBuffer.appendint(this.currentIndex))
            raise ((new JIndexOutOfBoundsException(stringBuffer.ToString())))
        let mutable oldValue : obj = this.objectArray.[index]
        this.objectArray.[index] <- element
        oldValue
    
    abstract clear : unit -> unit
    default this.clear() : unit =
        let mutable i : int = 0
        while i < this.currentIndex do
            this.objectArray.[i] <- null
            i <- i + 1
        this.currentIndex <- 0
    
    abstract size : unit -> int
    default this.size() : int =
        this.currentIndex
    
    abstract isEmpty : unit -> bool
    default this.isEmpty() : bool =
        this.currentIndex = 0
    
    abstract contains : anyType: obj -> bool
    default this.contains(anyType: obj) : bool =
        this.indexOf(anyType) >= 0
    
    abstract toArray : unit -> obj[]
    default this.toArray() : obj[] =
        this.arrayUtil.copyOf(this.objectArray, this.currentIndex)
    
    abstract toArrayType : objectArray: obj[] -> obj[]
    default this.toArrayType(objectArray: obj[]) : obj[] =
        let mutable jflow = 0
        let mutable jret : obj[] = Unchecked.defaultof<obj[]>
        if objectArray.Length < this.currentIndex then
            jret <- this.arrayUtil.copyOfType(this.objectArray, this.currentIndex, JR.getClass(objectArray))
            jflow <- 1
        if jflow = 0 then
            ignore (JSystem.arraycopy(this.objectArray, 0, objectArray, 0, this.currentIndex))
            if objectArray.Length > this.currentIndex then
                objectArray.[this.currentIndex] <- null
            jret <- objectArray
            jflow <- 1
        jret
    
    abstract clone : unit -> obj
    default this.clone() : obj =
        let mutable size : int = this.size()
        let mutable list_ : BasicArrayList = (new BasicArrayListS(size))
        let mutable anyType : obj = null
        let mutable index : int = 0
        while index < size do
            anyType <- this.objectArray.[index]
            ignore (list_.add(anyType))
            index <- index + 1
        list_
    
    override this.ToString() : string =
        let mutable COMMA_SEP : string = CommonSeps.getInstance().COMMA_SEP
        let mutable stringBuffer : StringMaker = (new StringMaker())
        let mutable index : int = 0
        while index < this.currentIndex do
            ignore (stringBuffer.append(this.objectArray.[index].ToString()))
            ignore (stringBuffer.append(COMMA_SEP))
            index <- index + 1
        stringBuffer.ToString()


