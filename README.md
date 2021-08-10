# ManagementCarApplication

Necessário criação do Schema ManagementCar no SQL Server para salvar dados no banco.

#BreakPoints:

#Api de Carros:

Listagem =>

        Get => api/CarroApi/GetCarros
            Filtros =>
                    Nome => api/CarroApi/GetCarroByNome?Nome=Example
                    Origem => api/CarroApi/GetCarroByOrigem?Origem=Example

Cadastro =>

        Post => api/CarroApi/CadastraCarro 
               => Dados enviados no corpo da requisição.
                  => Ex: 
                         {
                            "Nome": "Siena",
                            "KmPorGalao": 40,
                            "Cilindros": 5,
                            "CavaloPotencia": 80,
                            "Peso": 32345,
                            "Acelerecao": 19,
                            "Ano": "2021-01-01",
                            "Origem": "BR"
                        }
                        
                        
Edição =>

       Put => api/CarroApi/EditaCarro/Id   
              => Dados enviados no corpo da requisição
                 Ex:
                    {
                      "Id": 1,
                      "Nome": "Corsa",
                      "KmPorGalao": 100,
                      "Cilindros": 8,
                      "CavaloPotencia": 120,
                      "Peso": 3232323223,
                      "Acelerecao": 90,
                      "Ano": "2021-01-01T00:00:00",
                      "Origem": "USA"
                    }

Detalhamento =>

            Get => api/CarroApi/DetalhaCarro/Id
            
            
Exclusão =>

         Delete => api/CarroApi/DeletaCarro/Id


-------------------------------------------------------------------------------------------------------------------------------


#Api de Marcas:

Listagem =>

        Get => api/MarcaApi/GetMarcas
            Filtros =>
                    Nome => api/MarcaApi/GetMarcaByNome?Nome=Example
                    Origem => api/MarcaApi/GetMarcaByOrigem?Origem=Example

Cadastro =>

        Post => api/MarcaApi/CadastraMarca 
               => Dados enviados no corpo da requisição.
                  => Ex: 
                         {
                           "Nome": "Renault",
	                          "Origem": "FR"
                        }
                        
                        
Edição =>

       Put => api/MarcaApi/EditaMarca/Id   
              => Dados enviados no corpo da requisição
                 Ex:
                    {
                      "Id": 1,
                      "Nome": "Renault",
                      "Origem": "FRA"
                    }

Detalhamento =>

            Get => api/MarcaApi/DetalhaMarca/Id
            
            
Exclusão =>

         Delete => api/MarcaApi/DeletaMarca/Id
            


                
