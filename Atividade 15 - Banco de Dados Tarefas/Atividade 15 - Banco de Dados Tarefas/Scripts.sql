insert into TBTarefas
(
	Titulo, 
	DataCriação, 
	DataConclusão, 
	PercentualConcluído
)
values 
(
	  'TrabalhoFaculdade',
      '06/10/2021',
	  '06/15/2021',
	  10
)
select * from TBTarefas

update TBTarefas 
	set	
		[Titulo] = 'TrabalhoFaculdade', 
		[DataCriação]='06/10/2021', 
		[DataConclusão] = '06/15/2021',
	    [PercentualConcluído] = 100
	where 
		[Id] = 2
select * from TBTarefas

Delete from TBTarefas 
	where 
		[Id] = 5

select * from TBTarefas

select [Id], [Titulo], [DataCriação], [DataConclusão], [PercentualConcluído] from TBTarefas