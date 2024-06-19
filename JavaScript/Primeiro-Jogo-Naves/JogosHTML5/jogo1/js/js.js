function start() { // Inicio da função start()

	$("#inicio").hide();
	
	$("#fundoGame").append("<div id='jogador' class='anima1'></div>");
	$("#fundoGame").append("<div id='inimigo1' class='anima2'></div>");
	$("#fundoGame").append("<div id='inimigo2' ></div>");
	$("#fundoGame").append("<div id='amigo' class='anima3'></div>");

} // Fim da função start

//Principais variáveis do jogo
	
var jogo = {};
var velocidade=5;
var posicaoY = parseInt(Math.random() * 334);
var TECLA = {
    W: 87,
    S: 83,
    D: 68
    }
    
jogo.pressionou = [];

//Verifica se o usu�rio pressionou alguma tecla	
	
$(document).keydown(function(e){
    jogo.pressionou[e.which] = true;
    });
    
    $(document).keyup(function(e){
        jogo.pressionou[e.which] = false;
    });
	
//Game Loop

jogo.timer = setInterval(loop,30);

function loop() {

movefundo();
movejogador();
moveinimigo1();
moveinimigo2();

} // Fim da função loop()

//Função que movimenta o fundo do jogo
	
function movefundo() {
	
	esquerda = parseInt($("#fundoGame").css("background-position"));
	$("#fundoGame").css("background-position",esquerda-1);
	
	} // fim da função movefundo()

function movejogador() {
	
    if (jogo.pressionou[TECLA.W]) {
         var topo = parseInt($("#jogador").css("top"));
         $("#jogador").css("top",topo-9);

         if (topo<=0) {
		
            $("#jogador").css("top",topo+9);
        }
        
    }
        
     if (jogo.pressionou[TECLA.S]) {
            
        var topo = parseInt($("#jogador").css("top"));
        $("#jogador").css("top",topo+9);

        if (topo>=434) {	
            $("#jogador").css("top",topo-9);
                
        }
    }
        
    if (jogo.pressionou[TECLA.D]) {
            
         //Chama função Disparo	
     }
    
     } // fim da função movejogador()

     function moveinimigo1() {

        posicaoX = parseInt($("#inimigo1").css("left"));
        $("#inimigo1").css("left",posicaoX-velocidade);
        $("#inimigo1").css("top",posicaoY);
            
            if (posicaoX<=0) {
            posicaoY = parseInt(Math.random() * 334);
            $("#inimigo1").css("left",694);
            $("#inimigo1").css("top",posicaoY);
                
            }
    } //Fim da fun��o moveinimigo1()

    function moveinimigo2() {
        posicaoX = parseInt($("#inimigo2").css("left"));
	    $("#inimigo2").css("left",posicaoX-3);
				
		if (posicaoX<=0) {
			
		$("#inimigo2").css("left",775);
					
		}
    } // Fim da fun��o moveinimigo2()