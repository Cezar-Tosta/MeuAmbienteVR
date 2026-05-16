# Meu Primeiro Ambiente VR

**Autor:** Cezar de Sousa Tosta  
**Curso:** Residência em TIC 29 - Web3EduBrasil  
**Versão do Unity:** Unity 6.3 LTS (6000.3.13f1)  

---

## Descrição

Ambiente virtual em forma de praça simples, contendo uma mesa,
duas cadeiras, uma árvore e uma pedra decorativa sobre um gramado.
O projeto demonstra os fundamentos de XR com Unity e OpenXR.

---

## Como Navegar

1. Abra o projeto no Unity Hub
2. Abra a cena em `Assets/Scenes/SampleScene`
3. Pressione o botão Play (▶) no topo do editor
4. Clique na aba Game para ativar o foco
5. Use **WASD** ou **setas** do teclado para se mover
6. Mova o **mouse** para rotacionar a câmera (horizontal e vertical)
7. Pressione **Esc** para soltar o cursor

---

## Assets Utilizados

- Apenas primitivos nativos do Unity (Cube, Plane, Cylinder, Sphere)
- Materiais criados manualmente

---

## Dificuldades e Soluções

- **Input System incompatível com Unity 6:** resolvido atualizando
  o script para usar `UnityEngine.InputSystem`
- **Rotação da câmera:** implementada separando a câmera em um
  objeto pai (Player), permitindo rotação horizontal independente
  da rotação vertical

---

## Aprendizado

Aprendi a configurar um projeto Unity para XR, instalar o OpenXR,
organizar uma cena 3D e criar scripts de movimentação e rotação
completa compatíveis com o novo Input System do Unity 6.