const Http = new XMLHttpRequest();
const url = "https://localhost:44348/cliente";

var clientes = [];

function novoCadastro() {
	var id = document.getElementById("idCria").value;
	var nome = document.getElementById("nome").value;
	var email = document.getElementById("email").value;
	
	console.log(id);
	console.log(email);
	console.log(nome);
	
	var cliente = {
		'idCliente': id,
		'nome': nome,
		'email': email
	};
	
	console.log(cliente);
	
	if(clientes.some(function(c){
		return c.IdCliente == id
	})){
		Http.open("PUT", url, true);
	}
	else{
		Http.open("POST", url, true);
	}

	//Send the proper header information along with the request
	Http.setRequestHeader("Content-Type", "application/json;charset=UTF-8");

	Http.onreadystatechange = function() { // Call a function when the state changes.
		if (this.readyState === XMLHttpRequest.DONE && this.status === 200) {
			// Request finished. Do processing here.
		}
	}
	Http.send(JSON.stringify(cliente));
	
}

function deletarCadastro() {
	  var cliente = document.getElementById("idDeleta").value;
	  Http.open("DELETE", url + "/" + cliente, true);

	Http.onreadystatechange = function() { // Call a function when the state changes.
		if (this.readyState === XMLHttpRequest.DONE && this.status === 200) {
			// Request finished. Do processing here.
		}
	}
	Http.send();
}

function buscarCadastro() {
	Http.open("GET", url);
	Http.send();

	Http.onreadystatechange = (e) => {
	  clientes = JSON.parse(Http.responseText);
	  console.log(Http.responseText);
	  console.log(clientes);
	}
}