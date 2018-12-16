exec spIMDBGetReviewList 'MOV201801','Update','History, Drama, Biography','10','6','6','6'

 Procedure spIMDBGetReviewList

@MovieCode varchar(20) =null,

@Action varchar(10)=null,

@Genre varchar(50)= null,

@Performance int =null,

@Direction int =null,

@Editing int=null,

@Writing int =null





as



begin

    if(@Action = 'Update')

	Begin  



	    update dbo.WishList set 

		MovieGenre = @Genre, 

		PerformanceScore = @Performance, 

		DirectionScore = @Direction,

		EditingScore = @Editing,

		WritingScore = @Writing

		where MovieCode = @MovieCode

		select * from dbo.WishList



	end

	else

	begin

	select * from dbo.WishList

	end

     



end


select * from dbo.movie